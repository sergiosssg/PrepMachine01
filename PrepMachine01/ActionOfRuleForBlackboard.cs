using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class ActionOfRuleForBlackboard : ActionOfRuleAbstract, IAddingLabelToBlackboard, IRemovingLabelFromBlackboard
    {
        public override bool DoAction()
        {
            throw new NotImplementedException();
        }

        public override ActionOfRuleType GetActionOfRuleType()
        {
            throw new NotImplementedException();
        }


        public bool AddLabelToBlackboard(BlackBoard blackBoard, LabelOfProcessing label)
        {
            throw new NotImplementedException();
        }

        public bool RemoveLabelFromBlackboard(BlackBoard blackBoard, LabelOfProcessing label)
        {
            throw new NotImplementedException();
        }
    }
}
