
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
            I2C i2c = new I2C();
            
            Adxl345 Accelerometer = new Adxl345();
            L3g4200d Gyroscope = new L3g4200d();
            
            RegisterAdressMapADXL345 RegAccel = new RegisterAdressMapADXL345();
            RegisterAdressMapL3G4200D RegGyro = new RegisterAdressMapL3G4200D();
            
            Gyroscope.WriteDefaultL3G4200D();
           // Accelerometer.WriteDefaultADXL345();

            i2c.WriteData(RegAccel.Adress, RegAccel.PowerCtl, "0x08");
            

            Thread.Sleep(1000);

            while (true)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                
                var AccelX = Accelerometer.GetDataADXL345(RegAccel.DataX0, RegAccel.DataX1);
                var AccelY = Accelerometer.GetDataADXL345(RegAccel.DataY0, RegAccel.DataY1);
                var AccelZ = Accelerometer.GetDataADXL345(RegAccel.DataZ0, RegAccel.DataZ1);
                

                var GyroX = Gyroscope.GetDataL3G4200D(RegGyro.OutXL, RegGyro.OutXH);
                var GyroY = Gyroscope.GetDataL3G4200D(RegGyro.OutYL, RegGyro.OutYH);
                var GyroZ = Gyroscope.GetDataL3G4200D(RegGyro.OutZL, RegGyro.OutZH);
                
              //  var time = i2c.TimeMeaserument(RegAccel.Adress, RegAccel.DataX1);
               
                //Console.WriteLine(AccelX + " " + AccelY + " " + AccelZ);
                stopwatch.Stop();
                var meas = Convert.ToString(stopwatch.Elapsed.Milliseconds);
                var time = i2c.TimeMeasurementWrite(RegAccel.Adress, RegAccel.OfsX, "0x00");

                Console.WriteLine(time);

			}
            

        }
    }

}