using System;

namespace PM
{
    public class RuleSimple :  RuleAbstract, IResultOfActionRule
    {
        protected Action _action;


        public bool IAmValidAction => _action != null;

        public RuleSimple()
        {
            _isAccomplished = false;
            _action = null;
        }


        public Action ActionSilent
        {
            get => _action;
            set => _action += value;
        }

        public override IConditionRule[] GetConditionsOfRule()
        {
            throw new NotImplementedException();
        }

        public override bool IsRuleActive()
        {
            throw new NotImplementedException();
        }

        public override IActionRule[] GetActionsOfRule()
        {
            throw new NotImplementedException();
        }





    }
}


