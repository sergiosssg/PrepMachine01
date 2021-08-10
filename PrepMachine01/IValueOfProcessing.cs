using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IValueOfProcessing : IOperandTypeItem, INettoDataItem
    {
        public string ValueAsString
        {
            set;
            get;
        }
        public long ValueAsLong
        {
            set;
            get;
        }
        public int ValueAsInt
        {
            set;
            get;
        }
        public DateTime ValueAsDate
        {
            set;
            get;
        }
        public decimal ValueAsDecimal
        {
            set;
            get;
        }
        public bool ValueAsBool
        {
            set;
            get;
        }
    }
}
