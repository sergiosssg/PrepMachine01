using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface ILabelItem
    {
        public LabelType LabelTypeProperty
        {
            get;
            set;
        }

        public LabelOfProcessing LabelOfProcessingProperty
        {
            get;
            set;
        }
    }
}
