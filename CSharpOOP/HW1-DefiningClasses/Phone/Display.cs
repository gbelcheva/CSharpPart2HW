
namespace Phone
{
    using System;
    class Display
    {
        private double? size;
        private long? colours;

        public Display(double? displaySize, long? displayColours)
        {
            this.Size = displaySize;
            this.Colours = displayColours;
        }

        public double? Size
        {
            get 
            {
                return this.size;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be negative");
                }
                this.size = value;
            }
        }
        public long? Colours
        {
            get
            {
                return this.colours;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Number of colours cannot be negative");
                    }
                    this.colours = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Colours is in invalid format");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public override string ToString()
        {
            string DisplayInfo = "\nDisplay: " + this.Size + " inch, " + this.Colours + " colours";
            return DisplayInfo;
        }

    }
}
