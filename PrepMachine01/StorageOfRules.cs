﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class StorageOfRules : IStorage<IRule, String>, IEnumerable<IRule>
    {
        private IList<IRule> listOfRules;


        StorageOfRules()
        {
            listOfRules = new List<IRule>();
        }


        public int Amount()
        {
            return listOfRules.Count;
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
            foreach (var oneRule in listOfRules)
            {
                yield return oneRule;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (var oneRule in listOfRules)
            {
                yield return oneRule;
            }
        }


    }
}
