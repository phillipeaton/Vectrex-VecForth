\ Standard Vectrex cartridge header that must be present at $0000
\ Copyright (C) 2020 Phillip Eaton <inbox at phillipeaton.com>

HEX

STR" g GCE 2020�"
FD C, 0D C,             \ Intro Music
F8 C, 50 C, 20 C, 80 C, \ Height Width etc.
STR" VECFORTH�"
00 C,   \ End of Header

ASM: HERE EQU VFSTART
HERE 1 + EQU ENTRY-ADDR
9999 JMP, ;C \ Vectrex code to jump to VecForth ENTRY word, 9999 gets overwritten
