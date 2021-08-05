using System.Collections.Generic;

namespace PM
{
    public interface IResultOfActionOfRuleForBlackBoard
    {
        public bool GetLabelsOfResult(out List<LabelOfProcessing> lsLabelOfProcessings);
    }
}


