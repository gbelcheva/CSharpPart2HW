namespace Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        private static GSM iPhone;


        public GSM(string phoneModel, string phoneManufacturer)
        {
            this.Model = phoneModel;
            this.Manufacturer = phoneManufacturer;
        }

        public GSM(string phoneModel, string phoneManufacturer, decimal? phonePrice, string phoneOwner, Battery phoneBattery, Display phoneDisplay)
            : this(phoneModel, phoneManufacturer)
        {
            this.Price = phonePrice;
            this.Owner = phoneOwner;
            this.Battery = phoneBattery;
            this.Display = phoneDisplay;
        }
        public static GSM IPhone
        {
            get
            {
                return iPhone = new GSM("IPhone4S", "Apple", 399.99m, null, new Battery("616-0520", 200, 14, Battery.BatteryTypeEnum.LiPo), new Display(3.5, 16000000)); ;
            }

        }
        public string Model
        {
            get 
            {
                return this.model;
            }
            set 
            {
                try
                {
                    this.model = value;
                }
                catch (ArgumentNullException)
                {

                    Console.WriteLine("Model cannot be empty");
                }
                
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                try
                {
                    this.manufacturer = value;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Manufacturer cannot be empty");
                }
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get 
            {
                return this.owner;
            }
            set 
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            { 
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get 
            {
                return this.callHistory;
            }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()  
        {
            this.callHistory.Clear();
        }

        public decimal CalcTotalPrice(decimal pricePerMinute)
        {
            double totalCallMunites = this.callHistory.Select(c => c.Duration.TotalMinutes).Sum();
            decimal totalPrice = pricePerMinute * (decimal)totalCallMunites;
            return totalPrice;
        }
        public override string ToString() 
        {
            string tmpPrice = "";
            if (this.Price != null)
            {
                decimal tmp = (decimal)this.Price;
                tmpPrice = "\n" + tmp.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                
            }
            string GSMInfo = this.Model + " " + this.Manufacturer + this.Battery + this.Display + tmpPrice + " " + this.Owner;
            
            return GSMInfo;
        }
    }
}
