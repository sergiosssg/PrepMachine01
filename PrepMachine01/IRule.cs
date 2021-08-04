namespace PM
{
    public interface IRule
    {
        public IConditionRule[] getConditionsOfRule();
        public bool isRuleActive();
        public IActionRule[] getActionsOfRule();
    }
}


