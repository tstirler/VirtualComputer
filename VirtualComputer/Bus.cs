using System;

namespace VirtualComputer
{
    public class Bus
    {
        private int busValue;
        private int maxValue;
        public int BusWidthInBits;

        public int Value
        {
            get { return busValue; }
            set
            {
                busValue = value % maxValue;
            }
        }

        public Bus(int BusWidthInBits)
        {
            this.BusWidthInBits = BusWidthInBits;
            maxValue = (int)Math.Pow(2, BusWidthInBits);
            busValue = 0;
        }
    }
}