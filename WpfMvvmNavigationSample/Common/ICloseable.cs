using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmNavigationSample.Common
{
    public interface ICloseable : ICloseableEvent
    {
        void Close();
    }

    public interface ICloseableEvent
    {
        event EventHandler Closed;
    }
}
