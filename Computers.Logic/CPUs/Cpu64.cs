﻿namespace Computers.Logic.CPUs
{
    public class Cpu64 : Cpu
    {
        public Cpu64(byte numberOfCores)
            : base(numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        protected override int GetMaxValue()
        {
            return 1000;
        }
    }
}
