
using System;
using System.Diagnostics;
using System.Threading;
using Raspberry;


namespace Raspberry
{

    public class Run
    {
        
        public static void Main()
        {
            Adxl345 Accelerometer = new Adxl345();
            RegisterMapADXL345 Reg = new RegisterMapADXL345();

            while (true)
            {
                var x = Accelerometer.GetData(Reg.DataX0, Reg.DataX1);
                var y = Accelerometer.GetData(Reg.DataY0, Reg.DataY1);
                var z = Accelerometer.GetData(Reg.DataZ0, Reg.DataZ1);
                Console.WriteLine(x + " " + y + " " + z);
            }
            

        }
    }

}