using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class Register : IDepo<IRecord, String>
    {
        private Dictionary<long, IRecord> _records;


        public Register()
        {
            _records = new Dictionary<long, IRecord>();
        }

        public bool Add(IRecord tElement)
        {
            throw new NotImplementedException();
        }

        public bool addRecord(IRecord record)
        {
            long kodOfRecord = record.KODE;

            _records.Add(kodOfRecord, record);

            return true;
        }

        public bool Contains(IRecord tElement)
        {
            return _records.ContainsValue(tElement);
        }

        int IDepo<IRecord, String>.Amount()
        {
            throw new NotImplementedException();
        }

        bool IDepo<IRecord, String>.Load(string whereFrom)
        {
            throw new NotImplementedException();
        }

        bool IDepo<IRecord, String>.Loaded()
        {
            throw new NotImplementedException();
        }

        bool IDepo<IRecord, String>.Store(string where)
        {
            throw new NotImplementedException();
        }

        bool IDepo<IRecord, String>.Stored()
        {
            throw new NotImplementedException();
        }
    }
}
