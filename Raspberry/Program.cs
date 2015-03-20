
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
            
            RegisterMapADXL345 RegAccel = new RegisterMapADXL345();
            RegisterAdressMapL3G4200D RegGyro = new RegisterAdressMapL3G4200D();
            
            Gyroscope.WriteDefaultL3G4200D();
            Accelerometer.WriteDefaultADXL345();

            Thread.Sleep(1000);

            while (true)
            {
                TimeSpan time = new TimeSpan(0,0,0,0,1);

                var AccelX = Accelerometer.GetDataADXL345(RegAccel.DataX0, RegAccel.DataX1);
                var AccelY = Accelerometer.GetDataADXL345(RegAccel.DataY0, RegAccel.DataY1);
                var AccelZ = Accelerometer.GetDataADXL345(RegAccel.DataZ0, RegAccel.DataZ1);
                Thread.Sleep(time);

                var GyroX = Gyroscope.GetDataL3G4200D(RegGyro.OutXL, RegGyro.OutXH);
                var GyroY = Gyroscope.GetDataL3G4200D(RegGyro.OutYL, RegGyro.OutYH);
                var GyroZ = Gyroscope.GetDataL3G4200D(RegGyro.OutZL, RegGyro.OutZH);
                
                var tempC = 35.0 + ((i2c.ReadData(RegGyro.Adress, RegGyro.OutTemp) + 13200) / 280.0);
                //Console.WriteLine(GyroX + " " + GyroY + " " + GyroZ + " " + tempC + "||||" + AccelX + " " + AccelY + " " + AccelZ);
                Console.WriteLine(AccelX + " " + AccelY + " " + AccelZ);
                Thread.Sleep(time);
            }
            

        }
    }

}