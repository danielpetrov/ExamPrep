namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using CPUs;
    using HardDriver;
    using VideoCards;

    public class PersonalComputer : Computer
    {
        private const string WinMessage = "You win!";
        private const string WrongNumberStringFormat = "You didn't guess the number {0}.";

        public PersonalComputer(
            Cpu cpu,
            Ram ram,
            IEnumerable<HardDriver> hardDrives,
            VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.Rand(1, 10);

            var number = this.Ram.LoadValue();

            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format(WrongNumberStringFormat, number));
            }
            else
            {
                this.VideoCard.Draw(WinMessage);
            }
        }
    }
}
