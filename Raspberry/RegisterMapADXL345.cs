using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raspberry
{
    public class RegisterMapADXL345
    {
        public string Adress = "-y 1 0x53";       //-------------ADXL345 adress-------------
        public string DevID = "0x00";             //[R]   Device ID
        public string ThreshTap = "0x1D";         //[R/W] Tap threshold
        public string OfsX = "0x1E";              //[R/W] X-axis offset
        public string OfsY = "0x1F";              //[R/W] Y-axis offset
        public string OfsZ = "0x20";              //[R/W] Z-axis offset
        public string Dur = "0x21";               //[R/W] Tap duration
        public string Latent = "0x22";            //[R/W] Tap latency
        public string Window = "0x23";            //[R/W] Tap window
        public string ThreshAct = "0x24";         //[R/W] Activity threshold
        public string ThreshInact = "0x25";       //[R/W] Inactivity threshold
        public string TimeInact = "0x26";         //[R/W] Inactivity time
        public string ActInactCtl = "0x27";       //[R/W] Axis enable control for activity and inactivity detection
        public string TreshFF = "0x28";           //[R/W] Free-fall threshold
        public string TimeFF = "0x29";            //[R/W] Free-fall time
        public string TapAxes = "0x2A";           //[R/W] Axis control for single tap/double tap
        public string ActTapStatus = "0x2B";      //[R]   Source of single tap/double tap
        public string BwRate = "0x2C";            //[R/W] Data rate and power mode control
        public string PowerCtl = "0x2D";          //[R/W] Power-saving features control
        public string IntEnable = "0x2E";         //[R/W] Interrupt enable control
        public string IntMap = "0x2F";            //[R/W] Interrupt mapping control
        public string IntSource = "0x30";         //[R]   Source interrupts
        public string DataFormat = "0x31";        //[R/W] Data format control
        public string DataX0 = "0x32";            //[R]   X-Axis Data 0 LSB
        public string DataX1 = "0x33";            //[R]   X-Axis Data 1 MSB
        public string DataY0 = "0x34";            //[R]   Y-Axis Data 0 LSB
        public string DataY1 = "0x35";            //[R]   Y-Axis Data 1 MSB
        public string DataZ0 = "0x36";            //[R]   Z-Axis Data 0 LSB
        public string DataZ1 = "0x37";            //[R]   Z-Axis Data 1 MSB
        public string FifoCtl = "0x38";           //[R/W] FIFO control
        public string FifoStatus = "0x39";        //[R]   FIFO status

        //Register to set Data Rate
        public string BW_RATE_1600Hz = "0x0F";    //[W]   set 1600Hz
        public string BW_RATE_800Hz = "0x0E";     //[W]   set 800Hz
        public string BW_RATE_400Hz = "0x0D";     //[W]   set 400Hz
        public string BW_RATE_200Hz = "0x0C";     //[W]   set 200Hz
        public string BW_RATE_100Hz = "0x0B";     //[W]   set 100Hz
        public string BW_RATE_50Hz = "0x0A";      //[W]   set 50Hz
        public string BW_RATE_25Hz = "0x09";      //[W]   set 25Hz

        public string Range2G = "0x00";           //[W]   set range 2G
        public string Range4G = "0x01";           //[W]   set range 4G
        public string Range8G = "0x02";           //[W]   set range 8G
        public string Range16G = "0x03";          //[W]   set range 16G

        public string MeasureOff = "0x00";
        public string MeasureLoad = "0x10";
        public string MeasureOn = "0x08";           //

        public double EarthGravity = 9.80665;     //Constant of gravity
        public double ScaleMultplier = 0.004;     //
        
    }
}
