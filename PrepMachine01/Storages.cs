using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMachine01
{
    public interface IStorage
    {
        public long getHashOfHostMachine();

        public long getHastOfDateTimeStamp();

        public bool Store(string where);

        public bool Load(string whereFrom);


        public bool Stored();

        public bool Loaded();

        public int Amount();

    }
}
