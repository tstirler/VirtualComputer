using System;

namespace VirtualComputer
{
    internal class Register
    {
        public int maxValue { get; private set; }
        public int RegisterSizeInBits { get; private set; }

        public int Value { get; private set; }
        

        public Register(int RegisterSizeInBits)
        {
            this.RegisterSizeInBits = RegisterSizeInBits;
            maxValue = (int)Math.Pow(2, RegisterSizeInBits);
            Value = 0;
        }

        public int SetValue(int ValueToSet)
        {
            int returnCode = 0;
            Value = ValueToSet % maxValue;
            if(ValueToSet / maxValue >1) returnCode = 1;
            
            return returnCode;
        }
    }
}