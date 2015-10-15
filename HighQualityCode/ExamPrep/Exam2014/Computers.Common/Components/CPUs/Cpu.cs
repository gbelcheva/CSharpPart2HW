namespace Computers.Common.Components.CPUs
{
    using System;
    using Computers.Common.Components;

    public abstract class Cpu : IMotherboardComponent
    {
        private static readonly Random Random = new Random();
        private IMotherboard motherboard;
        
        internal Cpu(byte numberOfCores) 
        {
            this.NumberOfCores = numberOfCores;
        }

        public byte NumberOfCores { get; set; }

        public void AttachTo(IMotherboard motherboard)
        {
            this.motherboard = motherboard;
        }

        public void SquareNumber()
        {
            var data = this.motherboard.LoadRamValue();

            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > this.GetMaxValue())
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int value = data * data;

                this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        internal void Rand(int minValue, int maxValue)
        {
            int randomNumber;
            randomNumber = Random.Next(minValue, maxValue + 1);

            this.motherboard.SaveRamValue(randomNumber);
        }

        protected abstract int GetMaxValue();
    }
}
