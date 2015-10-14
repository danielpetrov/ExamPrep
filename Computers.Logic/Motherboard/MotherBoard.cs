namespace Computers.Logic.Motherboard
{
    using VideoCards;
    
    public class Motherboard : IMotherboard
    {
        public Motherboard(VideoCard videoCard, Ram ram)
        {
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        private Ram Ram { get; set; }

        private VideoCard VideoCard { get; set; }

        public void DrawOnVideoCard(string data)
        {
            this.VideoCard.Draw(data);
        }

        public int LoadRamValue()
        {
            return this.Ram.LoadValue();
        }

        public void SaveRamValue(int value)
        {
            this.Ram.SaveValue(value);
        }
    }
}
