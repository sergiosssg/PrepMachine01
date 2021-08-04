namespace PM
{
    public class RegisterActionInRule : ActionAbstract, IActionRule
    {
        public override bool doAction()
        {
            bool retResult = false;

            return retResult;
        }

        override public ActionRuleType getActionRuleType()
        {
            return ActionRuleType.REGISTR_ACTION;
        }
    }
}


