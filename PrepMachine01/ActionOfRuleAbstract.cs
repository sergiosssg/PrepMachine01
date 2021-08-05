using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public abstract class ActionOfRuleAbstract : IActionOfRule
    {
        public abstract bool DoAction();


        public abstract ActionOfRuleType GetActionOfRuleType();

    }
}
