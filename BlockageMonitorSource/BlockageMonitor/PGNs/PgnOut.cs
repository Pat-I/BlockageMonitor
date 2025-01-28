using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockageMonitor
{
    public partial class frmStart
    {
        //*********************************************
        //Row Crop config going out
        public class CPGN_E0
        {
            /// <Arduino config>
            /// PGN - 224 - E0
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcConfig = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public int numSections = 5;
            public int targetSpeedX10 = 6;
            public int highRowWidthX10 = 7;
            public int lowRowWidthX10 = 8;
            public int highTargetPopulation = 9;
            public int lowTargetPopulation = 10;
            public int doublesFactor = 11;
            public int isMetric = 12;
            // PGN
            int crc = 0;

            public CPGN_E0()
            {
                pgn[numSections] = 0;
                pgn[targetSpeedX10] = 0;
                pgn[lowRowWidthX10] = 0;
                pgn[highRowWidthX10] = 0;
                pgn[highTargetPopulation] = 0;
                pgn[lowTargetPopulation] = 0;
                pgn[doublesFactor] = 0;
                pgn[isMetric] = 0;
            }


            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }









        /// <summary>
		/// rowCropConfig PGN - 228 - E0
		/// </summary>
		public CPGN_E0 p_224 = new CPGN_E0();
    }
}
