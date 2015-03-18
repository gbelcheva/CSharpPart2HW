namespace Phone
{
    using System;
    class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryTypeEnum? batteryType;
        
        public Battery(string batteryModel, double? batteryHoursIdle, double? batteryHoursTalk, BatteryTypeEnum? phoneBatteryType)
        {
            this.Model = batteryModel;
            this.HoursIdle = batteryHoursIdle;
            this.HoursTalk = batteryHoursTalk;
            this.BatteryType = phoneBatteryType;
        }

        public enum BatteryTypeEnum
        {
            LiIon,
            NiMH,
            NiCd,
            LiPo
        }

        public string Model
        {
            get 
            {
                return this.model;
            }
            set 
            {
                this.model = value;
            }
        }
        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Hours cannot be negative");
                    }
                    this.hoursIdle = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hours is in invalid format");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                try
                {
                    this.hoursTalk = value;
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Hours cannot be negative");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hours is in invalid format");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public BatteryTypeEnum? BatteryType
        {
            get 
            {
                return this.batteryType;
            }
            set 
            {
                this.batteryType = value; // catch exception
            }
        }

        public override string ToString()
        {
            string BatteryInfo = "\nBattery: " + this.Model + ", " + this.HoursIdle + " h idle time, " + this.HoursTalk + " h talk time, " + this.BatteryType;
            return BatteryInfo;
        }

        
    }
}
