using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IAddingLabelToBlackboard
    {
        public bool AddLabelToBlackboard(BlackBoard blackBoard, LabelOfProcessing label);
    }
}
