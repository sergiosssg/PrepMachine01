using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IOrderNumberItem
    {
        public int OrderNumberInChain
        {
            get; set;
        }
    }
}
