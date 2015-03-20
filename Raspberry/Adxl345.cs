using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raspberry;

namespace Raspberry
{
    class Adxl345
    {
        RegisterMapADXL345 Reg = new RegisterMapADXL345();
        I2C I2C = new I2C();

        public void WriteDefaultADXL345()
        {
            I2C.WriteData(Reg.Adress, Reg.PowerCtl, Reg.MeasureOff);
            I2C.WriteData(Reg.Adress, Reg.PowerCtl, Reg.MeasureLoad);
            I2C.WriteData(Reg.Adress, Reg.PowerCtl, Reg.MeasureOff);
        }

        public double GetDataADXL345(string LSB, string MSB)
        {
            var Data0 = I2C.ReadData(Reg.Adress, LSB);
            var Data1 = I2C.ReadData(Reg.Adress, MSB);

            var Data = Convert.ToDouble(Data1 << 8 | Data0);

            Data = Data * 4 / Math.Pow(2, 10);
            Data = Data * Reg.EarthGravity;

            return Data;

        }
    }
}
