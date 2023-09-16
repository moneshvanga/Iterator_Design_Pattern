using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatingTVChannels
{
    public class ChannelCollection : IChannelCollection
    {
        private List<Channel> _channelsList;
        public ChannelCollection()
        {
            _channelsList = new List<Channel>();
        }
        public void AddChannel(Channel c)
        {
            _channelsList.Add(c);
        }
        public void RemoveChannel(Channel c)
        {
            _channelsList.Remove(c);
        }
        public IIterator GetIterator()
        {
            return new ChannelIterator(_channelsList);
        }
    }
}
