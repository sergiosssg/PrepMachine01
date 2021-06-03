using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class BlackBoard
    {
        private IDictionary<bool, ILabelOfPrecessing> labelsSortedByAsProcessed;


        public BlackBoard()
        {
            labelsSortedByAsProcessed =  new Dictionary<bool, ILabelOfPrecessing>();
        }


        public void addLabel(ILabelOfPrecessing newLabelOfProcessing)
        {

        }

        public bool containLabel(ILabelOfPrecessing labelOfProcessing)
        {

            return false;
        }
    }
}
