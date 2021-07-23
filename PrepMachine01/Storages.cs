using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMachine01
{
    public interface IStorage
    {
        public long getHashOfHostMachine();

        public long getHastOfDateTimeStamp();
    }
}
