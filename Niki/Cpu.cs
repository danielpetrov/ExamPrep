﻿namespace Computers.UI
{
    using System;

    public class Cpu
    {
        private static readonly Random Random = new Random();

        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly VideoCard videoCard;
        ////TODO shoud CPU know about videocard and ram?
        internal Cpu(byte numberOfCores, byte numberOfBits, Ram ram, VideoCard videoCard)
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        private byte NumberOfCores { get; set; }

        public void SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                this.SquareNumber64(500);
            }

            if (this.numberOfBits == 64)
            {
                this.SquareNumber64(1000);
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

        /////TODO rename
        private void SquareNumber64(int maxValue)
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > maxValue)
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
     }
}
