using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IRowIndexatorItem
    {
        public long RowNumber
        {
            get; set;
        }
    }

    public interface IColumnIndexatorItem
    {
        public int ColumnNumber
        {
            get; set;
        }

        public string ColumnName
        {
            get; set;
        }
    }

    public interface ITableIndicators : IRowIndexatorItem, IColumnIndexatorItem
    {
    }
}
