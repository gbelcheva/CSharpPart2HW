namespace PhoneStoreExample.Phones
{
    using PhoneStoreExample.Contracts;
    using System;

    public class MobilePhone: IProcessable
    {
        private double cost;

        public MobilePhone(PhoneType type, int cost = 0)
        {
            this.Type = type;
            this.Cost = cost;
        }

        public PhoneType Type { get; set; }

        public double Cost { get; set; }

        public string GetDescription()
        {
            return "Phone of type: " + this.Type;
        }

        public void Process()
        {
            this.Cost = (0.9) * this.Cost;
            Console.Write("The new cost is: {0} and the type is {1}. ",
                this.Cost, this.Type);
        }

        public override string ToString()
        {
            return "Type: " + this.Type + " and Cost: " + this.Cost;
        }
    }
}
