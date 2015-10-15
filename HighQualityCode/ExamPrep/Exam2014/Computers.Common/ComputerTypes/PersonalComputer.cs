namespace Computers.Common.ComputerTypes
{
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Computers.Common.Components.HardDrives;

    public class PersonalComputer : Computer
    {
        public PersonalComputer(
        Cpu cpu,
        Ram ram,
        HardDrive hardDrive,
        VideoCard videoCard)
            : base(cpu, ram, hardDrive, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.Rand(1, 10);
            var number = this.Ram.LoadValue();
            if (number != guessNumber)
            {
                VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                VideoCard.Draw("You win!");
            }
        }
    }
}