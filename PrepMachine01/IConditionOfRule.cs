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
        public System.Predicate<System.Tuple<ValueLocationType, IValueOfProcessing, IValueOfProcessing, ComparisonOperatorType>> PredicateForComparision
        {
            get;
            set;
        }

        public bool AccomplichCondition(ValueLocationType valueLocationType, IValueOfProcessing leftValue, IValueLocationTypeItem rightValue, ComparisonOperatorType comparisonOperatorType);
    }
}


