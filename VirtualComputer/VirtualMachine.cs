namespace VirtualComputer
{
    internal class VirtualMachine
    {
        public bool IsRunning { get; set; }
        public static Bus DataBus;
        public static Bus AdressBus;

        private CPU processor;


        public VirtualMachine (int DataBusWidthInBits, int AdressBusWidthInBits)
        {
            IsRunning = true;
            processor = new CPU();
            DataBus = new Bus(DataBusWidthInBits);
            AdressBus = new Bus(AdressBusWidthInBits);
        }

        public void Update()
        {
            processor.Update();
        }
    }
}