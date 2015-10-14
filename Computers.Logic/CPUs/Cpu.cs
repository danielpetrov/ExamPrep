namespace Computers.Logic.CPUs
{
    using System;
    using Motherboard;
    
    public abstract class Cpu : IMotherboardComponent
    {
        protected static readonly Random Random = new Random();

        public const string NumberTooHighMessage = "Number too high.";
        public const string NumberTooLowMessage = "Number too low.";
        private const string SquareInfoStringFormat = "Square of {0} is {1}.";

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
                this.Motherboard.DrawOnVideoCard(NumberTooLowMessage);
            }
            else if (data > this.GetMaxValue())
            {
                this.Motherboard.DrawOnVideoCard(NumberTooHighMessage);
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.Motherboard.DrawOnVideoCard(string.Format(SquareInfoStringFormat, data, value));
            }
        }

        internal void Rand(int minValue, int maxValue)
        {
            int randomNumber = Random.Next(minValue, maxValue + 1);
            this.Motherboard.SaveRamValue(randomNumber);
        }

        protected abstract int GetMaxValue();
     }
 }
