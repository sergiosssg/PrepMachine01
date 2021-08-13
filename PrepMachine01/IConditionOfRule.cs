namespace PM
{
    public interface IConditionOfRule
    {
        public ComparisonOperatorType ComparisonOperatorType
        {
            get;
            set;
        }
        public OperandType OperandTypeProperty 
        {
            get;
            set;
        }
        public IFuzzyValue LogicComboProperty
        {
            get;
            set;
        }
        public FuzzyMeasure FuzzyLevel
        {
            get;
            set;
        }
        public ValueLocationType ValueLocationTypeProperty 
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


