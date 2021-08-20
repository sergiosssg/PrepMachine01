using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IStorage<T, S>
    {
        public bool Store(S where);

        public bool Load(S whereFrom);


        public bool Stored();

        public bool Loaded();

        public int Amount();

    }
}
