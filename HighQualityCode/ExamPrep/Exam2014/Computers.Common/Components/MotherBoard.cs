namespace Computers.Common.Components
{
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;

    public class Motherboard : IMotherboard
    {
        public Motherboard(Cpu cpu, Ram ram, VideoCard videoCard)
        {
            cpu.AttachTo(this);
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        public Cpu Cpu { get; set; }

        private Ram Ram { get; set; }

        private VideoCard VideoCard { get; set; }

        public int LoadRamValue()
        {
            int value = this.Ram.LoadValue();

            return value;
        }

        public void SaveRamValue(int value)
        {
            this.Ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.VideoCard.Draw(data);
        }
    }
}
