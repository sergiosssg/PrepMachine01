using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class Register : IStorage
    {
        private Dictionary<long, IRecord> _records;


        public Register()
        {
            _records = new Dictionary<long, IRecord>();
        }



        public bool addRecord(IRecord record)
        {
            long kodOfRecord = record.KODE;

            _records.Add(kodOfRecord, record);

            return true;
        }

        int IStorage.Amount()
        {
            throw new NotImplementedException();
        }

        bool IStorage.Load(string whereFrom)
        {
            throw new NotImplementedException();
        }

        bool IStorage.Loaded()
        {
            throw new NotImplementedException();
        }

        bool IStorage.Store(string where)
        {
            throw new NotImplementedException();
        }

        bool IStorage.Stored()
        {
            throw new NotImplementedException();
        }
    }
}
