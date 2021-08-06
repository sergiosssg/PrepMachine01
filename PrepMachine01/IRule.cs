namespace PM
{
    public interface IRule
    {
        public IConditionOfRule[] GetConditionsOfRule();
        public bool IsRuleActive();
        public IActionOfRule[] GetActionsOfRule();
    }
}


