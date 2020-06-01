using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JniorWeb.Models
{

    public partial class JniorDataModel
    {
        [JsonProperty("Hostname")]
        public string Hostname { get; set; }

        [JsonProperty("IpAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

        [JsonProperty("SerialNumber")]
        public long SerialNumber { get; set; }

        [JsonProperty("JANOSVersion")]
        public string JanosVersion { get; set; }

        [JsonProperty("CinemaVersion")]
        public string CinemaVersion { get; set; }

        [JsonProperty("UptimeSeconds")]
        public long UptimeSeconds { get; set; }

        [JsonProperty("UptimeString")]
        public string UptimeString { get; set; }
    }

    
    public class JniorPortModel
    {
        

        [JsonProperty("DIN1")]
        public bool DIN1 { get; set; } = false;

        [JsonProperty("DIN2")]
        public bool DIN2 { get; set; } = false;

        [JsonProperty("DIN3")]
        public bool DIN3 { get; set; } = false;

        [JsonProperty("DIN4")]
        public bool DIN4 { get; set; } = false;

        [JsonProperty("ROUT1")]
        public bool ROUT1 { get; set; } = false;

        [JsonProperty("ROUT2")]
        public bool ROUT2 { get; set; } = false;

        [JsonProperty("ROUT3")]
        public bool ROUT3 { get; set; } = false;

        [JsonProperty("ROUT4")]
        public bool ROUT4 { get; set; } = false;

        [JsonProperty("ROUT5")]
        public bool ROUT5 { get; set; } = false;

        [JsonProperty("ROUT6")]
        public bool ROUT6 { get; set; } = false;

        [JsonProperty("ROUT7")]
        public bool ROUT7 { get; set; } = false;

        [JsonProperty("ROUT8")]
        public bool ROUT8 { get; set; } = false;

        [JsonProperty("ROUT9")]
        public bool ROUT9 { get; set; } = false;

        [JsonProperty("ROUT10")]
        public bool ROUT10 { get; set; } = false;

        [JsonProperty("ROUT11")]
        public bool ROUT11 { get; set; } = false;

        [JsonProperty("ROUT12")]
        public bool ROUT12 { get; set; } = false;

        [JsonProperty("ROUT13")]
        public bool ROUT13 { get; set; } = false;

        [JsonProperty("ROUT14")]
        public bool ROUT14 { get; set; } = false;

        [JsonProperty("ROUT15")]
        public bool ROUT15 { get; set; } = false;

        [JsonProperty("ROUT16")]
        public bool ROUT16 { get; set; } = false;
    }





    public class JniorTempModel
    {

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Celsius")]
        public double Celsius { get; set; }

        [JsonProperty("Fahrenheit")]
        public double Fahrenheit { get; set; }
    }

}
