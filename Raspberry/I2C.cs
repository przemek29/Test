using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Raspberry
{
   public class I2C
    {
        //public string ReadData { get; set; }
        // public void WriteData { get; set; }

        private string i2cgetExe = "/usr/sbin/i2cget";
        private string i2csetExe = "/usr/sbin/i2cset";

        private string hexString = "";
        private Process p;

        public I2C()
        {
            p = new Process();
        }

        public void WriteData(string Adress, string Register, string Value)
        {


            // Don't raise event when process exits
            p.EnableRaisingEvents = false;
            // We're using an executable not document, so UseShellExecute false
            p.StartInfo.UseShellExecute = false;
            // Redirect StandardError
            p.StartInfo.RedirectStandardError = true;
            // Redirect StandardOutput so we can capture it
            p.StartInfo.RedirectStandardOutput = true;
            // i2cgetExe has full path to executable
            // Need full path because UseShellExecute is false

            p.StartInfo.FileName = i2csetExe;
            // Pass arguments as a single string
            p.StartInfo.Arguments = Adress + " " + Register + " " + Value;
            // Now run i2cget & wait for it to finish

            p.Start();
            p.WaitForExit();
        }

        public long ReadData(string Adress, string Register)
        {

            // Don't raise event when process exits
            p.EnableRaisingEvents = false;
            // We're using an executable not document, so UseShellExecute false
            p.StartInfo.UseShellExecute = false;
            // Redirect StandardError
            p.StartInfo.RedirectStandardError = true;
            // Redirect StandardOutput so we can capture it
            p.StartInfo.RedirectStandardOutput = true;
            // i2cgetExe has full path to executable
            // Need full path because UseShellExecute is false

            p.StartInfo.FileName = i2cgetExe;
            // Pass arguments as a single string
            p.StartInfo.Arguments = Adress + " " + Register;
            // Now run i2cget & wait for it to finish

            p.Start();
            p.WaitForExit();
            // Data returned in format 0x00
            string data = p.StandardOutput.ReadToEnd();
            // Get LSB & parse as integer
            hexString = data.Substring(2, 2);
            
            long HexInt = Int32.Parse(hexString,
                                  System.Globalization.NumberStyles.AllowHexSpecifier);
            

            return HexInt;

            
        }

        
        
    }
}
