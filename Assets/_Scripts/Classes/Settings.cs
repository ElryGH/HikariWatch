using System.Collections.Generic;

namespace HikariWatch
{
    public class Settings
    {
        public DeviceType DeviceType;
        public bool IsSetup;
        public PCSettings PCSettings;
        public MobileDeviceSettings MobileDeviceSettings;
    }

    public class MobileDeviceSettings
    {
        public DeviceMode DeviceMode;
    }

    public class PCSettings
    {
        
    }

    public enum DeviceType
    {
        PC,
        Mobile
    }

    public enum DeviceMode
    {
        Watch,
        Remote
    }
}