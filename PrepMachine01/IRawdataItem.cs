using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IRawdataItem
    {
        public byte[] RawData
        {
            get; set;
        }
    }
}
