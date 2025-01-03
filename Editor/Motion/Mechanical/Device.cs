namespace Michmond.MoCap.Motion.Mechanical
{
    class Device
    {
        public const int defaultPort = 1625;

        public string ip { get; private set; } = "";
        public int? port { get; private set; } = null;

        public DeviceStatus status = DeviceStatus.Offline;



        public void Contect()
        {
            int port = this.port ?? defaultPort;
        }

        public void Disconect()
        {

        }

        public void StreamingEnable()
        {

        }

        public void StreamingDisable()
        {

        }
    }


    enum DeviceStatus
    {
        Active,
        Online,
        Offline,
        Connecting,
    }
}