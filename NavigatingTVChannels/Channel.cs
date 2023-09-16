namespace NavigatingTVChannels
{
    public enum ChannelType
    {
        News,
        Sports,
        Movies,
        Music
    }
    public class Channel
    {
        public double Frequency { get; private set; }
        public ChannelType Type { get; private set; }
        public Channel(double frequency, ChannelType type)
        {
            Frequency = frequency;
            Type = type;
        }
    }
}