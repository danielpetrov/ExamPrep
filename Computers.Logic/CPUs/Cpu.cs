namespace Computers.Logic.CPUs
{
    using System;
    using VideoCards;

    public abstract class Cpu
    {
        protected static readonly Random Random = new Random();

        protected Ram ram;

        protected VideoCard videoCard;
        ////TODO shoud CPU know about videocard and ram?
        protected Cpu(byte numberOfCores, Ram ram, VideoCard videoCard)
        {
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        protected byte NumberOfCores { get; set; }
  
        public void SquareNumber()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > this.GetMaxValue())
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
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
            this.ram.SaveValue(randomNumber);
        }

        protected abstract int GetMaxValue();
    }
 }
