namespace PM
{
    public abstract class RuleAbstract : IRule
    {
        public abstract IConditionRule[] GetConditionsOfRule();

        public abstract bool IsRuleActive();

        public abstract IActionRule[] GetActionsOfRule();


        /// <summary>
        /// 
        /// </summary>

        protected bool _isAccomplished;

        public bool IAmAcomplished => _isAccomplished;


        public void reset() => _isAccomplished = false;
    }
}


