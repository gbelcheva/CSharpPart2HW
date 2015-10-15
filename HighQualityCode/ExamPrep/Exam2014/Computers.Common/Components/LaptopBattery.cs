namespace Computers.Common.Components
{
    public class LaptopBattery
    {
        private const int InitialCharge = 50;

        internal LaptopBattery()
        {
            this.Percentage = InitialCharge;
        }

        internal int Percentage { get; set; }

        internal void Charge(int p)
        {
            this.Percentage += p;

            if (this.Percentage > 100)
            {
                this.Percentage = 100;
            }

            if (this.Percentage < 0)
            {
                this.Percentage = 0;
            }
        }
    }
}
