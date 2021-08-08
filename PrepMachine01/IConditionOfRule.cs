namespace PM
{
    public interface IConditionOfRule
    {
        public ComparisonOperatorType getComparisonOperatorType();
        public OperandType getOperandType();
        public LogicCombo getLogicCombo();
        public FuzzyMeasure getЕhresholdLevel();
        public ValueLocationType GetValueLocationType();
        public System.Predicate<LabelOfProcessing> PredicateForComparision
        {
            get;
            set;
        }

    }
}


