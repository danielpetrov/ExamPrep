﻿namespace Computers.Logic.CPUs
{
    public class Cpu32 : Cpu
    {
        public const int MaxValue = 500;

        public Cpu32(byte numberOfCores)
            : base(numberOfCores)
        {
        }

        protected override int GetMaxValue()
        {
            return MaxValue;
        }
    }
}
