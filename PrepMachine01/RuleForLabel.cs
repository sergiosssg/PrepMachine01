using System;
using System.Collections.Generic;

namespace PM
{
    public class RuleForLabel : RuleAbstract, IResultOfActionRuleForBlackBoard, IResultOfActionRule
    {
        private Func<List<LabelOfProcessing>, List<LabelOfProcessing>> _actionAddingLabel;
        private List<LabelOfProcessing> _lresultLabelOfProcessings;

        public RuleForLabel()
        {
            _actionAddingLabel = null;
            _lresultLabelOfProcessings = new List<LabelOfProcessing>();
        }

        public Func<List<LabelOfProcessing>, List<LabelOfProcessing>> ActionAddingLabel
        {
            get => _actionAddingLabel;
            set => _actionAddingLabel += value;
        }

        /////////////////////
        ///
        /////////////////////


        public override IActionOfRule[] GetActionsOfRule()
        {
            throw new NotImplementedException();
        }

        public override IConditionRule[] GetConditionsOfRule()
        {
            throw new NotImplementedException();
        }

        public bool getLabelsResult(out List<LabelOfProcessing> lsLabelOfProcessings)
        {


            lsLabelOfProcessings = _lresultLabelOfProcessings;
            return _isAccomplished;
        }

        public override bool IsRuleActive()
        {
            throw new NotImplementedException();
        }

        new public void reset()  {  base.reset(); _lresultLabelOfProcessings.Clear(); }

    }
}


