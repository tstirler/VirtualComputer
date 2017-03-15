using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            int DataBusWidthInBits = 8;
            int AdressBusWidthInBits = 16;

            VirtualMachine machine = new VirtualMachine(DataBusWidthInBits, AdressBusWidthInBits);
            do
            {
                machine.Update();
            } while (machine.IsRunning);
        }
    }
}
