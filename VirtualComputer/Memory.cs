using System;

namespace VirtualComputer
{
    internal class Memory
    {
        private int[] memory;
        private int maxValue;
        
        public void Read(int Address)
        {
            VirtualMachine.DataBus.Value = memory[Address];
        }

        public void Write(int Address)
        {
            memory[Address] = VirtualMachine.DataBus.Value % maxValue;
            
        }

        public Memory(int MemorySizeInKiloByte)
        {
            maxValue = (int)Math.Pow(2, VirtualMachine.DataBus.BusWidthInBits);
            memory = new int[MemorySizeInKiloByte * 1024];
        }
    }
}