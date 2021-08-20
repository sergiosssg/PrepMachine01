using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IStorage<T, S>
    {
        public bool Store(string where);

        public bool Load(string whereFrom);


        public bool Stored();

        public bool Loaded();

        public int Amount();

    }
}
