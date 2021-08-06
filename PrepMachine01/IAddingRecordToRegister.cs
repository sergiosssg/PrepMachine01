using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IAddingRecordToRegister
    {
        bool AddRecordToRegister(Register register, IRecord record);
    }
}
