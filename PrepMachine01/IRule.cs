﻿namespace PM
{
    public interface IRule
    {
        public IConditionRule[] GetConditionsOfRule();
        public bool IsRuleActive();
        public IActionRule[] GetActionsOfRule();
    }
}


