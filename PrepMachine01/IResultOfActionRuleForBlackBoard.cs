using System.Collections.Generic;

namespace PM
{
    public interface IResultOfActionRuleForBlackBoard
    {
        public bool getLabelsResult(out List<LabelOfProcessing> lsLabelOfProcessings);
    }
}


