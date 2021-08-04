using System;

namespace PM
{
    public class SimpleActionInRule :  ActionAbstract, IActionRule, IResultOfActionRule
    {
        protected Action _action;


        public bool IAmValidAction => _action != null;

        public SimpleActionInRule()
        {
            _isAccomplished = false;
            _action = null;
        }


        public Action ActionSilent
        {
            get => _action;
            set => _action += value;
        }


        override public bool doAction()
        {
            bool retResult = false;
            if (IAmValidAction) { _action(); retResult = true; }


            base._isAccomplished = true;
            return retResult;
        }

        public override ActionRuleType getActionRuleType()
        {
            return ActionRuleType.EMPTY_ACTION;
        }
    }
}


