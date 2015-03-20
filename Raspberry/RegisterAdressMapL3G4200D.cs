using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raspberry
{
    public class RegisterAdressMapL3G4200D
    {
        public string Adress = "-y 1 0x69";     //-------------L3G4200D adress-------------

        public string WhoAmI = "0x0F";          //[R]
        public string CtrlReg1 = "0x20";        //[RW]
        public string CtrlReg2 = "0x21";        //[RW]
        public string CtrlReg3 = "0x22";        //[RW]
        public string CtrlReg4 = "0x23";        //[RW]
        public string CtrlReg5 = "0x24";        //[RW]
        public string Reference = "0x25";       //[RW]
        public string OutTemp = "0x26";         //[R]
        public string StatusReg = "0x27";       //[R]
        public string OutXL = "0x28";           //[R]
        public string OutXH = "0x29";           //[R]
        public string OutYL = "0x2A";           //[R]
        public string OutYH = "0x2B";           //[R]
        public string OutZL = "0x2C";           //[R]
        public string OutZH = "0x2D";           //[R]
        public string FifoCtrlReg = "0x2E";     //[RW]    
        public string FifoSrcReg = "0x2F";      //[R]
        public string Int1Cfg = "0x30";         //[RW]
        public string Int1Src = "0x31";         //[R]
        public string Int1TshXH = "0x32";       //[RW]
        public string Int1TshXL = "0x33";       //[RW]
        public string Int1TshYH = "0x34";       //[RW]
        public string Int1TshYL = "0x35";       //[RW]
        public string Int1TshZH = "0x36";       //[RW]
        public string Int1TshZL = "0x37";       //[RW]
        public string Int1Duration = "0x38";    //[RW]  

        public string DefaultCtrlReg1 = "0x0F"; //albo 0x0F
        public string DefaultCtrlReg3 = "0x08";
        public string DefaultCtrlReg4 = "0x80"; //albo 0x20

    }
}
