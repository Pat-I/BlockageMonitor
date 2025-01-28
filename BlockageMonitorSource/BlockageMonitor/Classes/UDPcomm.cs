using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlockageMonitor
{
    public class UDPComm
    {
        private readonly frmStart mf;
        private byte[] buffer = new byte[1024];
        private string cConnectionName;
        private bool cIsUDPSendConnected;
        private string cLog;
        private IPAddress cNetworkEP;
        private int cReceivePort;   // local ports must be unique for each app on same pc and each class instance
        private int cSendFromPort;
        private int cSendToPort;
        private string cSubNet;
        private HandleDataDelegateObj HandleDataDelegate = null;
        private Socket recvSocket;
        private Socket sendSocket;
        

        public UDPComm(frmStart CallingForm, int ReceivePort, int SendToPort, int SendFromPort, string ConnectionName, string DestinationEndPoint = "")
        {
            mf = CallingForm;
            cReceivePort = ReceivePort;
            cSendToPort = SendToPort;
            cSendFromPort = SendFromPort;
            cConnectionName = ConnectionName;
            SetEP(DestinationEndPoint);
        }

        private delegate void HandleDataDelegateObj(int port, byte[] msg);

        public bool IsUDPSendConnected { get => cIsUDPSendConnected; set => cIsUDPSendConnected = value; }

        public string NetworkEP
        {
            get { return cNetworkEP.ToString(); }
            set
            {
                string[] data;
                if (IPAddress.TryParse(value, out IPAddress IP))
                {
                    data = value.Split('.');
                    cNetworkEP = IPAddress.Parse(data[0] + "." + data[1] + "." + data[2] + ".255");
                    mf.Tls.SaveProperty("EndPoint_" + cConnectionName, value);
                    cSubNet = data[0].ToString() + "." + data[1].ToString() + "." + data[2].ToString();
                }
            }
        }

        public string SubNet
        { get { return cSubNet; } }


        public void Close()
        {
            recvSocket.Close();
            sendSocket.Close();
        }

        public string Log()
        {
            return cLog;
        }

        //sends byte array
        public void SendUDPMessage(byte[] byteData)
        {
            if (IsUDPSendConnected)
            {
                try
                {
                    int PGN = byteData[0] | byteData[1] << 8;
                    AddToLog("               > " + PGN.ToString());

                    if (byteData.Length != 0)
                    {
                        // network
                        IPEndPoint EndPt = new IPEndPoint(cNetworkEP, cSendToPort);
                        sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, EndPt, new AsyncCallback(SendData), null);
                    }
                }
                catch (Exception ex)
                {
                    mf.Tls.WriteErrorLog("UDPcomm/SendUDPMessage " + ex.Message);
                }
            }
        }

        public void StartUDPServer()
        {
            try
            {
                // initialize the delegate which updates the message received
                HandleDataDelegate = HandleData;

                // initialize the receive socket
                recvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                recvSocket.Bind(new IPEndPoint(IPAddress.Any, cReceivePort));

                // initialize the send socket
                sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Initialise the IPEndPoint for the server to send on port
                IPEndPoint server = new IPEndPoint(IPAddress.Any, cSendFromPort);
                sendSocket.Bind(server);

                // Initialise the IPEndPoint for the client - async listner client only!
                EndPoint client = new IPEndPoint(IPAddress.Any, 0);

                // Start listening for incoming data
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref client, new AsyncCallback(ReceiveData), recvSocket);
                IsUDPSendConnected = true;
            }
            catch (Exception e)
            {
                mf.Tls.WriteErrorLog("UDPcomm/StartUDPServer: \n" + e.Message);
            }
        }

        private void AddToLog(string NewData)
        {
            cLog += DateTime.Now.Second.ToString() + "  " + NewData + Environment.NewLine;
            if (cLog.Length > 100000)
            {
                cLog = cLog.Substring(cLog.Length - 98000, 98000);
            }
            cLog = cLog.Replace("\0", string.Empty);
        }

        private void HandleData(int Port, byte[] Data)
        {
            try
            {
                if (Data.Length > 1)
                {
                    int PGN = Data[1] << 8 | Data[0];   // rc modules little endian
                    AddToLog("< " + PGN.ToString());

                    switch (PGN)
                    {
                        case 32100:
                            mf.Sensors.ParseByteData(Data);
                            break;

                        case 32200:
                            mf.Sensors200.ParseByteData(Data);
                            break;

                        case 33152: // AOG, 0x81, 0x80
                            switch (Data[3])
                            {
                                case 254:
                                    
                                    // AutoSteer AGIO PGN
                                    mf.AutoSteerPGN.ParseByteData(Data);
                                    break;


                                //// Feedback from Arduino Planter Monitor
                                case 224:
                                    {
                                        mf.rc.fbNumSections = (int)Data[5];
                                        mf.rc.fbTargetSpeed = (float)Data[6] / 10.0f;
                                        mf.rc.fbRowWidth = ((float)(Data[7] << 8) + (float)Data[8]) * .1f; // + (float)data[8]; // ; mc.actualSteerAngleChart = (Int16)((data[6] << 8) + data[5]);
                                        mf.rc.fbTargetPopulation = ((int)(Data[9] << 8) + (float)Data[10]) * 10.0f;
                                        mf.rc.fbDoublesFactor = (float)Data[11] / 100.0f;

                                        if (Data[12] == 1)
                                        {
                                            mf.rc.fbIsMetric = true;
                                        }
                                        else
                                        {
                                            mf.rc.fbIsMetric = false;
                                        }
                                        if (mf.rc.fbNumSections != Properties.Settings.Default.setVehicle_numSections ||
                                                mf.rc.fbTargetSpeed != Properties.Settings.Default.setPlanterSpeed ||
                                                Math.Abs(mf.rc.fbRowWidth - Properties.Settings.Default.setPlanterRowWidth) > .001 ||
                                                mf.rc.fbTargetPopulation != Properties.Settings.Default.setPlanterTargetPopulation ||
                                                mf.rc.fbDoublesFactor != Properties.Settings.Default.setPlanterDoublesFactor ||
                                                mf.rc.fbIsMetric != Properties.Settings.Default.setMenu_isMetric)
                                        {

                                            mf.p_224.pgn[mf.p_224.highRowWidthX10] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f) >> 8));
                                            mf.p_224.pgn[mf.p_224.lowRowWidthX10] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f));
                                            mf.p_224.pgn[mf.p_224.numSections] = (byte)Properties.Settings.Default.setVehicle_numSections;
                                            mf.p_224.pgn[mf.p_224.targetSpeedX10] = (byte)(Properties.Settings.Default.setPlanterSpeed * 10.0f);
                                            mf.p_224.pgn[mf.p_224.highTargetPopulation] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterTargetPopulation / 10) >> 8));
                                            mf.p_224.pgn[mf.p_224.lowTargetPopulation] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterTargetPopulation / 10));
                                            mf.p_224.pgn[mf.p_224.doublesFactor] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterDoublesFactor * 100.0f));
                                            if (Properties.Settings.Default.setMenu_isMetric)
                                            {
                                                mf.p_224.pgn[mf.p_224.isMetric] = unchecked((byte)(int)1);
                                            }
                                            else
                                            {
                                                mf.p_224.pgn[mf.p_224.isMetric] = unchecked((byte)(int)0);
                                            }

                                            SendUDPMessage(mf.p_224.pgn);

                                           // mf.TimedMessageBox(2000, "Planter Module", "Settings Sent To Planter Monitor Module");
                                        } // end case
                                        break;
                                    }

                                //// Population by row ////
                                case 225:
                                    {
                                        int popIndex = 7;
                                        for (int i = 5; i < 13; i++)
                                        {
                                            popIndex += 1;
                                            //								if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                            //								rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / (float.Parse(Properties.Settings.Default.setPlanterTargetPopulation))) - 100f;
                                            mf.rc.rcPopulation[popIndex] = Data[i] * 1000f;
                                            mf.rc.rcPopulationPercent[popIndex] = (Data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                            if (mf.rc.rcPopulationPercent[popIndex] < -15f) mf.rc.rcPopulationPercent[popIndex] = -15f;
                                            if (mf.rc.rcPopulationPercent[popIndex] > 115f) mf.rc.rcPopulationPercent[popIndex] = 115f;

                                        }
                                        break;
                                    }


                                //// Population by row ////
                                case 226:
                                    {
                                        int popIndex = -1;
                                        for (int i = 5; i < 13; i++)
                                        {
                                            popIndex += 1;
                                            //								if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                            mf.rc.rcPopulation[popIndex] = Data[i] * 1000f;
                                            mf.rc.rcPopulationPercent[popIndex] = (Data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                            if (mf.rc.rcPopulationPercent[popIndex] < -15f) mf.rc.rcPopulationPercent[popIndex] = -15f;
                                            if (mf.rc.rcPopulationPercent[popIndex] > 115f) mf.rc.rcPopulationPercent[popIndex] = 115f;
                                        }
                                        break;
                                    }
                                //// Doubles by row ////
                                case 227:
                                    {

                                        int doubleIndex = -2;

                                        for (int i = 5; i < 13; i++)
                                        {
                                            doubleIndex += 3;
                                            mf.rc.rcDoubles[doubleIndex] = (byte)Data[i] & 0b000111;
                                            Data[i] = ((byte)(Data[i] >> 4));
                                            doubleIndex -= 1;
                                            mf.rc.rcDoubles[doubleIndex] = (byte)Data[i] & 0b000111;
                                        }
                                        break;
                                    }
                                //// Skips by row ////
                                case 228:
                                    {
                                        int skipIndex = -2;
                                        for (int i = 5; i < 13; i++)
                                        {
                                            skipIndex += 3;
                                            mf.rc.rcSkips[skipIndex] = (byte)Data[i] & 0b000111;
                                            Data[i] = ((byte)(Data[i] >> 4));
                                            skipIndex -= 1;
                                            mf.rc.rcSkips[skipIndex] = (byte)Data[i] & 0b000111;
                                        }
                                        break;
                                    }
                                //// Row crop summary ////
                                case 229:
                                    {
                                        mf.population = (Int16)((Data[6] << 8) + Data[5]);
                                        mf.population *= 10;
                                        mf.singulation = (Int16)((Data[12] << 8) + Data[11]);
                                        mf.singulation = mf.singulation / 10;
                                        mf.skipPercent = (Int16)((Data[8] << 8) + Data[7]);
                                        mf.skipPercent = mf.skipPercent / 10;
                                        mf.doublesPercent = (Int16)((Data[10] << 8) + Data[9]);
                                        mf.doublesPercent = mf.doublesPercent / 10;
                                        break;
                                    }
                                //// Row crop status by row -- sets color ////
                                ////
                                /*
                                case 230:   // test by Jim to catch row sensor state 16 rows stored in data[5] and data[6]
                                    {


                                        int jptest = 0;
                                        int numToTest = 4;
                                        if (tool.numOfSections < 4) numToTest = tool.numOfSections;
                                        for (int i = 0; i < numToTest; i++)
                                        {
                                            jptest = data[5];
                                            jptest = (byte)data[5] & 0b000011;
                                            if (jptest == 0)
                                            {
                                                rc.SetStateNormal(i);
                                            }
                                            else if (jptest == 1)
                                            {
                                                rc.SetStateOut(i);
                                                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                            }
                                            else if (jptest == 2)
                                            {
                                                rc.SetStateSkip(i);
                                            }
                                            else if (jptest == 3)
                                            {
                                                rc.SetStateDouble(i);
                                            }

                                            data[5] = ((byte)(data[5] >> 2));
                                        }

                                        numToTest = 8;
                                        if (tool.numOfSections < 8) numToTest = tool.numOfSections;
                                        for (int i = 4; i < numToTest; i++)
                                        {
                                            jptest = data[6] & 0b000011;
                                            if (jptest == 0)
                                            {
                                                rc.SetStateNormal(i);
                                            }
                                            else if (jptest == 1)
                                            {
                                                rc.SetStateOut(i);
                                                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                            }
                                            else if (jptest == 2)
                                            {
                                                rc.SetStateSkip(i);
                                            }
                                            else if (jptest == 3)
                                            {
                                                rc.SetStateDouble(i);
                                            }

                                            data[6] = ((byte)(data[6] >> 2));
                                        }

                                        numToTest = 12;
                                        if (tool.numOfSections < 12) numToTest = tool.numOfSections;
                                        for (int i = 8; i < numToTest; i++)
                                        {
                                            jptest = data[7] & 0b000011;
                                            if (jptest == 0)
                                            {
                                                rc.SetStateNormal(i);
                                            }
                                            else if (jptest == 1)
                                            {
                                                rc.SetStateOut(i);
                                                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                            }
                                            else if (jptest == 2)
                                            {
                                                rc.SetStateSkip(i);
                                            }
                                            else if (jptest == 3)
                                            {
                                                rc.SetStateDouble(i);
                                            }

                                            data[7] = ((byte)(data[7] >> 2));
                                        }

                                        numToTest = 16;
                                        if (tool.numOfSections < 16) numToTest = tool.numOfSections;
                                        for (int i = 12; i < numToTest; i++)
                                        {
                                            jptest = data[8] & 0b000011;
                                            if (jptest == 0)
                                            {
                                                rc.SetStateNormal(i);
                                            }
                                            else if (jptest == 1)
                                            {
                                                rc.SetStateOut(i);
                                                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                            }
                                            else if (jptest == 2)
                                            {
                                                rc.SetStateSkip(i);
                                            }
                                            else if (jptest == 3)
                                            {
                                                rc.SetStateDouble(i);
                                            }

                                            data[8] = ((byte)(data[8] >> 2));
                                        }

                                        rc.fbFeedbackCounter = (int)data[9];

                                        break;

                                    }
                                    */







                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("UDPcomm/HandleData " + ex.Message);
            }
        }

        private void ReceiveData(IAsyncResult asyncResult)
        {
            try
            {
                // Initialise the IPEndPoint for the client
                EndPoint epSender = new IPEndPoint(IPAddress.Any, 0);

                // Receive all data
                int msgLen = recvSocket.EndReceiveFrom(asyncResult, ref epSender);

                byte[] localMsg = new byte[msgLen];
                Array.Copy(buffer, localMsg, msgLen);

                // Listen for more connections again...
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(ReceiveData), epSender);

                int port = ((IPEndPoint)epSender).Port;
                // Update status through a delegate
                mf.Invoke(HandleDataDelegate, new object[] { port, localMsg });
            }
            catch (System.ObjectDisposedException)
            {
                // do nothing
            }
            catch (Exception ex)
            {
                //mf.Tls.ShowHelp("ReceiveData Error \n" + e.Message, "Comm", 3000, true);
                mf.Tls.WriteErrorLog("UDPcomm/ReceiveData " + ex.Message);
            }
        }

        private void SendData(IAsyncResult asyncResult)
        {
            try
            {
                sendSocket.EndSend(asyncResult);
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog(" UDP Send Data" + ex.ToString());
            }
        }

        private void SetEP(string DestinationEndPoint)
        {
            try
            {
                if (IPAddress.TryParse(DestinationEndPoint, out _))
                {
                    NetworkEP = DestinationEndPoint;
                }
                else
                {
                    string EP = mf.Tls.LoadProperty("EndPoint_" + cConnectionName);
                    if (IPAddress.TryParse(EP, out _))
                    {
                        NetworkEP = EP;
                    }
                    else
                    {
                        NetworkEP = "192.168.1.255";
                    }
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("UDPcomm/SetEP " + ex.Message);
            }
        }
    }
}