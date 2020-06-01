using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JniorWeb.Models
{

    public class JniorDataModel
    {
        public string Hostname { get; set; } = "Ingen Data";
        public string IpAddress { get; set; } = "Ingen Data";
        public string Model { get; set; } = "Ingen Data";
        public int SerialNumber { get; set; } = 0;
        public string JANOSVersion { get; set; } = "Ingen Data";
        public string CinemaVersion { get; set; } = "Ingen Data";
        public int UptimeSeconds { get; set; } = 0;
        public string UptimeString { get; set; } = "Ingen Data";
    }


    public class JniorPortModel
    {
        public bool DIN1 { get; set; }
        public bool DIN2 { get; set; }
        public bool DIN3 { get; set; }
        public bool DIN4 { get; set; }
        public bool ROUT1 { get; set; }
        public bool ROUT2 { get; set; }
        public bool ROUT3 { get; set; }
        public bool ROUT4 { get; set; }
        public bool ROUT5 { get; set; }
        public bool ROUT6 { get; set; }
        public bool ROUT7 { get; set; }
        public bool ROUT8 { get; set; }
        public bool ROUT9 { get; set; }
        public bool ROUT10 { get; set; }
        public bool ROUT11 { get; set; }
        public bool ROUT12 { get; set; }
        public bool ROUT13 { get; set; }
        public bool ROUT14 { get; set; }
        public bool ROUT15 { get; set; }
        public bool ROUT16 { get; set; }
    }


    public class JniorTempModel
    {
        public string Address { get; set; }
        public float Celsius { get; set; }
        public float Fahrenheit { get; set; }
    }

}
