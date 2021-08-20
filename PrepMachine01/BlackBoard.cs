using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class BlackBoard : IStorage<IValueOfProcessing, string>
    {
        private IDictionary<bool, IValueOfProcessing> _labelsSortedByAsProcessed;
        private ISet<IValueOfProcessing> _setOfLabels;


        public BlackBoard()
        {
            _labelsSortedByAsProcessed =  new Dictionary<bool, IValueOfProcessing>();
            _setOfLabels = new HashSet<IValueOfProcessing>();
        }

        public bool Add(IValueOfProcessing tElement)
        {
            _labelsSortedByAsProcessed.Add( false, tElement);
            _setOfLabels.Add( tElement);
            return true;
        }

        public bool Contains(IValueOfProcessing tElement)
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







        /// <summary>
        /// 
        /// </summary>
        /// <param name="newLabelOfProcessing"></param>

        public int Amount()
        {
            throw new NotImplementedException();
        }
    }
}
