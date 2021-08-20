using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class Register : IStorage<IRecord, String>
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

        int IStorage<IRecord, String>.Amount()
        {
            throw new NotImplementedException();
        }

        bool IStorage<IRecord, String>.Load(string whereFrom)
        {
            throw new NotImplementedException();
        }

        bool IStorage<IRecord, String>.Loaded()
        {
            throw new NotImplementedException();
        }

        bool IStorage<IRecord, String>.Store(string where)
        {
            throw new NotImplementedException();
        }

        bool IStorage<IRecord, String>.Stored()
        {
            throw new NotImplementedException();
        }
    }
}
