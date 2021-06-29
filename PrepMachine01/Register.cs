using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class Register
    {
        private Dictionary<long, RegisterRecord> _records;


        public Register()
        {
            _records = new Dictionary<long, RegisterRecord>();
        }



        public bool addRecord()
        {

            return true;
        }
    }
}
