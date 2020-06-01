public interface IJniorDataModel
{
    string CinemaVersion { get; set; }
    string Hostname { get; set; }
    string IpAddress { get; set; }
    string JanosVersion { get; set; }
    long Model { get; set; }
    long SerialNumber { get; set; }
    long UptimeSeconds { get; set; }
    string UptimeString { get; set; }
}