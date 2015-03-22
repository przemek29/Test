using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raspberry;
using System.Data;
using System.Threading;

namespace Raspberry
{
    class L3g4200d
    {
        RegisterAdressMapL3G4200D Reg = new RegisterAdressMapL3G4200D();
        I2C I2C = new I2C();

        
        public void WriteDefaultL3G4200D()
        {
            I2C.WriteData(Reg.Adress, Reg.CtrlReg1, Reg.DefaultCtrlReg1);
            I2C.WriteData(Reg.Adress, Reg.CtrlReg3, Reg.DefaultCtrlReg3);
            I2C.WriteData(Reg.Adress, Reg.CtrlReg4, Reg.DefaultCtrlReg4);
        }

        
        public double GetDataL3G4200D(string LSB, string MSB)
        {

            var LowData = I2C.ReadData(Reg.Adress, LSB);
            var HighData = I2C.ReadData(Reg.Adress, MSB);
            var Data = HighData << 8 | LowData;

            Data = (Data & 0x8000) != 0 ? -(short)~(Data - 1) : Data;
            Data /= 114;
            //var Data = HighData << 8 | LowData;
            
            
            return Data;

        }
    }
}
