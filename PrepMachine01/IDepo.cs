using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    /**
     *   IStorage<T, S>
     *   where  store  T data  in  S strorages
     *   
     */
    public interface IDepo<T, S>
    {
        public bool Store(S where);

        public bool Load(S whereFrom);

        /**
         *   returns  true  when tElement sucsessfully added,
         *   false otherwise
         */
        public bool Add(T tElement);

        public bool Contains(T tElement);

        public bool Stored();

        public bool Loaded();

        public int Amount();

    }
}
