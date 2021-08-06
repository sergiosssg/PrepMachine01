using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IRemovingLabelFromBlackboard
    {
        bool RemoveLabelFromBlackboard(BlackBoard blackBoard, LabelOfProcessing label);
    }
}
