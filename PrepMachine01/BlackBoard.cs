using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class BlackBoard
    {
        private IDictionary<bool, LabelOfProcessing> labelsSortedByAsProcessed;


        public BlackBoard()
        {
            labelsSortedByAsProcessed =  new Dictionary<bool, LabelOfProcessing>();
        }


        public void addLabel(LabelOfProcessing newLabelOfProcessing)
        {

        }

        public bool containsLabel(LabelOfProcessing labelOfProcessing)
        {
            return false;
        }




    }
}
