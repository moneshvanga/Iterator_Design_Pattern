using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatingTVChannels
{
        public class ChannelIterator : IIterator
        {
            private readonly List<Channel> _channels;
            private int _position;
            public ChannelIterator(List<Channel> channels)
            {
                _channels = channels;
            }
            public bool HasNext()
            {
                return _position < _channels.Count;
            }
            public Channel Next()
            {
                Channel channel = _channels[_position];
                _position++;
                return channel;
            }
        }
}
