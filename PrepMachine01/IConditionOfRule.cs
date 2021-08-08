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
        public LogicCombo LogicComboProperty
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
        public System.Predicate<LabelOfProcessing> PredicateForComparision
        {
            get;
            set;
        }

    }
}


