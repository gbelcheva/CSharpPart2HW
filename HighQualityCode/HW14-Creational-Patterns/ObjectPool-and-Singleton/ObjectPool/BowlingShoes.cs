namespace BowlExample.ObjectPool
{
    public class BowlingShoes
    {
        private int size;

        public BowlingShoes() 
        { 
        }

        public int Size
        {
            get 
            { 
                return this.size; 
            }

            set 
            { 
                this.size = value; 
            }
        }

        public override string ToString()
        {
            string result;

            if (this.Size != 0)
            {
                result = "Bowling shoes, size " + this.Size;
            }
            else
            {
                result = "Bowling shoes";
            }

            return result;
        }
    }
}
