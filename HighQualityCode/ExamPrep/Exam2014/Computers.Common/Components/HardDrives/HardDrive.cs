namespace Computers.Common.Components.HardDrives
{
    public abstract class HardDrive
    {
        internal HardDrive()
        {
        }

        public abstract int Capacity { get; }

        public abstract void SaveData(int addr, string newData);

        public abstract string LoadData(int address);
    }
}
