using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class BlackBoard
    {
        private IDictionary<bool, LabelOfProcessing> _labelsSortedByAsProcessed;
        private ISet<LabelOfProcessing> _setOfLabels;


        public BlackBoard()
        {
            _labelsSortedByAsProcessed =  new Dictionary<bool, LabelOfProcessing>();
            _setOfLabels = new HashSet<LabelOfProcessing>();
        }

        public void addLabel(LabelOfProcessing newLabelOfProcessing)
        {
            if (newLabelOfProcessing != null)
            {
                _labelsSortedByAsProcessed.Add(false, newLabelOfProcessing);
                _setOfLabels.Add(newLabelOfProcessing);
            }
        }

        public bool containsLabel(LabelOfProcessing labelOfProcessing)
        {
            return false;
        }
    }
}
