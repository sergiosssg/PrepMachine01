using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class AtionOfRuleForRegister : ActionOfRuleAbstract, IAddingRecordToRegister, IRemovingRecordFromRegister
    {
        public override bool DoAction()
        {
            throw new NotImplementedException();
        }

        public override ActionOfRuleType GetActionOfRuleType()
        {
            throw new NotImplementedException();
        }

        public bool AddRecordToRegister(Register register, IRecord record)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRecordFromRegister(Register register, IRecord record)
        {
            throw new NotImplementedException();
        }
    }
}
