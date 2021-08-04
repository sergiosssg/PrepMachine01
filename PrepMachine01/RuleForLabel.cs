using System;
using System.Collections.Generic;

namespace PM
{
    public class RuleForLabel : ActionAbstract, IResultOfActionRuleForBlackBoard, IResultOfActionRule
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

        public override bool doAction()
        {
            bool retResult = false;
            if (_actionAddingLabel != null) { _actionAddingLabel(_lresultLabelOfProcessings); retResult = true; }


            return retResult;
        }

        override public ActionRuleType getActionRuleType()
        {
            return ActionRuleType.LABEL_ACTION;
        }


        public bool getLabelsResult(out List<LabelOfProcessing> lsLabelOfProcessings)
        {


            lsLabelOfProcessings = _lresultLabelOfProcessings;
            return _isAccomplished;
        }

        new public void reset()  {  base.reset(); _lresultLabelOfProcessings.Clear(); }
    }
}


