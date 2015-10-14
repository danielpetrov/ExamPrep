namespace Computers.Logic.CPUs
{
    using System;
    using Motherboard;
    using VideoCards;

    public abstract class Cpu : IMotherboardComponent
    {
        protected static readonly Random Random = new Random();

        protected Cpu(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        protected byte NumberOfCores { get; set; }

        private IMotherboard Motherboard { get; set; }

        public void AttachTo(IMotherboard motherboard)
        {
            this.Motherboard = motherboard;
        }

        public void SquareNumber()
        {
            var data = this.Motherboard.LoadRamValue();
            if (data < 0)
            {
                this.Motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > this.GetMaxValue())
            {
                this.Motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.Motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        internal void Rand(int a, int b)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(0, 1000);
            }
            while (!(randomNumber >= a && randomNumber <= b));
            this.Motherboard.SaveRamValue(randomNumber);
        }

        protected abstract int GetMaxValue();
     }
 }
