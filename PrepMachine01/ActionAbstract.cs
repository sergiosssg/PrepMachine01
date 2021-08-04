namespace PM
{
    public abstract class ActionAbstract : IActionRule
    {
        protected bool _isAccomplished;

        public bool IAmAcomplished => _isAccomplished;

        public abstract bool doAction();

        public abstract ActionRuleType getActionRuleType();

        public void reset() => _isAccomplished = false;
    }
}


