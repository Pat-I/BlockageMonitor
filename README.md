Planter monitor

PGNs
From AOG: PGN254
Read the speed and 16 sections.

From Planter Module to Planter Monitor and back:
PGN224 (r.c. Config)
0x80, 0x81, ox7B, 0xE0 (224), 8(lenght), Nbr of rows(sections), target speed X10, RowWidth X10 HI, target speed X10, RowWidth X10 LO, Target Pop HI, Target Pop LO, Double factor, IsMetric,

From Planter Module to Planter Monitor
PGN 225
0x80, 0x81, ox7B, 0xE1 (225), 8(lenght), Row9(Population /1000),Row10, Row11, Row12, Row13, Row14, Row15, Row16
PGN 226
0x80, 0x81, ox7B, 0xE2 (226), 8(lenght), Row1(Population /1000),Row2, Row3, Row4, Row5, Row6, Row7, Row8
PGN227 (doubles)
PGN228 (Skips)
PGN229 (Summary)
PGN230 (Status, not implemented)
