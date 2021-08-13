using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IComparisonOfProcessing
    {
        public bool AmIFuzzyValue
        {
            get;
        }

        public ComparisonOperatorType comparisonOperatorTypeProperty
        {
            get;
            set;
        }

        public System.Predicate<System.Tuple<ValueLocationType, IValueOfProcessing, IValueOfProcessing, IComparisonOfProcessing>> PredicateForComparision
        {
            get;
            set;
        }

    }
}
