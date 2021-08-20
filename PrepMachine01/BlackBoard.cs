using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class BlackBoard 
    {
        private IDictionary<bool, IValueOfProcessing> _labelsSortedByAsProcessed;
        private ISet<IValueOfProcessing> _setOfLabels;


        public BlackBoard()
        {
            _labelsSortedByAsProcessed =  new Dictionary<bool, IValueOfProcessing>();
            _setOfLabels = new HashSet<IValueOfProcessing>();
        }











        /// <summary>
        /// 
        /// </summary>
        /// <param name="newLabelOfProcessing"></param>

        public void addLabel(IValueOfProcessing newLabelOfProcessing)
        {
            if (newLabelOfProcessing != null)
            {
                _labelsSortedByAsProcessed.Add(false, newLabelOfProcessing);
                _setOfLabels.Add(newLabelOfProcessing);
            }
        }

        public bool containsLabel(IValueOfProcessing labelOfProcessing)
        {
            return false;
        }
    }
}
