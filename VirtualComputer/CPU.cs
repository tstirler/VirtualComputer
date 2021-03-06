﻿using System;

namespace VirtualComputer
{
    internal class CPU
    {
        private Register registerA;
        private Register registerB;
        private Register registerC;
        private Register registerE;

        private int registerD
        {
            get
            {
                return (int)(registerC.Value / (registerC.maxValue - (Math.Pow(2, VirtualMachine.DataBus.BusWidthInBits))));
            }
            set
            {
                registerC.SetValue((int)((registerC.Value % registerC.maxValue) + (value * (Math.Pow(2, VirtualMachine.DataBus.BusWidthInBits)))));
            }
        }

        private enum Opcodes
        {
            NOP,
            ADD,
            SUB,
            LOAD,
            SAVE,
            JMP,
            JZ,
            JE,
            JNE,
            JG,
            JGE,
            JL,
            JLE,
            RST,
            HALT=255
        }

        private Register addressRegister;
        private Memory onBoardMemory;
        private int onBoardMemoryInKiloByte = 4;
        
        public bool Ready { get; private set; }
        public bool Halt { get; private set; }
        public bool OperationOverflow { get; private set; }
        public bool OperationUnderflow { get; private set; }

        public CPU()
        {
            registerA = new Register(VirtualMachine.DataBus.BusWidthInBits);
            registerB = new Register(VirtualMachine.DataBus.BusWidthInBits);
            registerC = new Register(VirtualMachine.DataBus.BusWidthInBits * 2);
            registerE = new Register(VirtualMachine.DataBus.BusWidthInBits * 2);
            addressRegister = new Register(VirtualMachine.AdressBus.BusWidthInBits);
            onBoardMemory = new Memory(onBoardMemoryInKiloByte);
        }

        public void Update()
        {
        }

        #region OP-codes
        public void DoNop()
        {

        }

        public void DoAdd()
        {
        }

        public void DoSub()
        {

        }

        public void DoLoad()
        {

        }

        public void DoSave()
        {

        }

        public void DoJump()
        {

        }

        public void DoReset()
        {

        }

        public void DoHalt()
        {

        }

        #endregion
    }
}
