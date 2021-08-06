using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IRemovingRecordFromRegister
    {
        public bool RemoveRecordFromRegister(Register register, IRecord record);
    }
}
