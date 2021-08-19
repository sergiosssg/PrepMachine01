using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class StorageOfRules : IStorage, IEnumerable<IRule>
    {
        public int Amount()
        {
            throw new NotImplementedException();
        }

        public bool Load(string whereFrom)
        {
            throw new NotImplementedException();
        }

        public bool Loaded()
        {
            throw new NotImplementedException();
        }

        public bool Store(string where)
        {
            throw new NotImplementedException();
        }

        public bool Stored()
        {
            throw new NotImplementedException();
        }

        IEnumerator<IRule> IEnumerable<IRule>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
