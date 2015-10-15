namespace Computers.Common.Components.HardDrives
{
    using System.Collections.Generic;

    public class SingleHardDrive : HardDrive
    {
        private int capacity;
        private Dictionary<int, string> data;

        public SingleHardDrive(int capacity)
            : base()
        {
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
        }

        public override int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public override void SaveData(int addr, string newData)
        {
            this.data[addr] = newData;
        }

        public override string LoadData(int address)
        {
            return this.data[address];
        }
    }
}