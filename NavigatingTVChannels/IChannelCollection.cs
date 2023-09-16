using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatingTVChannels
{
    public interface IChannelCollection
    {
        void AddChannel(Channel c);
        void RemoveChannel(Channel c);
        IIterator GetIterator();
    }
}
