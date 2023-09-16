using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatingTVChannels
{
    public interface IIterator
    {
        bool HasNext();
        Channel Next();
    }
}
