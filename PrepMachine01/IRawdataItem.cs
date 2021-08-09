using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IRawDataItem
    {
        public byte[] RawData
        {
            get; set;
        }
    }
}
