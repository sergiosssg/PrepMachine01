namespace PM
{
    public interface IConditionRule
    {
        public ComparisonOperatorType getComparisonOperatorType();
        public OperandType getOperandType();
        public LogicCombo getLogicCombo();
        public FuzzyMeasure getЕhresholdLevel();

    }
}


