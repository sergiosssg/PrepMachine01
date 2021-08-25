using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IValueItem<V>
    {
        public V getValue();
        public bool setValue(V val);

        public OperandType getType();
        public bool AssignedValue();
    }
}
