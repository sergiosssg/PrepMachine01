using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{

    public class ActionInRule : IActionRule
    {
        private bool _isAccomplished;
        private Func<List<LabelOfProcessing>, List<LabelOfProcessing>> _actionAddingLabel;
        private Action _actionSilent;
        private List<LabelOfProcessing> _lresultLabelOfProcessings;

        public bool IAmLabelAdder => _actionAddingLabel != null;
        public bool IAmSilent => _actionSilent != null;
        public bool IAmAcomplished => _isAccomplished;

        public ActionInRule()
        {
            _isAccomplished = false;
            _actionAddingLabel = null; _actionSilent = null;
            _lresultLabelOfProcessings = new List<LabelOfProcessing>();
        }

        public Func<List<LabelOfProcessing>, List<LabelOfProcessing>> ActionAddingLabel
        {
            get => _actionAddingLabel;
            set => _actionAddingLabel += value;
        }

        public Action ActionSilent
        {
            get => _actionSilent;
            set => _actionSilent += value;
        }
        public List<LabelOfProcessing> doAction()
        {
            if (IAmLabelAdder) _actionAddingLabel(_lresultLabelOfProcessings);
            if (IAmSilent) _actionSilent();


            _isAccomplished = true;
            return _lresultLabelOfProcessings;
        }

        public void reset() => _isAccomplished = false;
    }


    public class SimpleVoidActionInRule : IActionRule
    {
        private bool _isAccomplished;
        private Action _action;

        public SimpleVoidActionInRule()
        {
            _isAccomplished = false;
            _action = null;
        }




        public void reset() => _isAccomplished = false;
    }



    public interface IRule
    {
        public IConditionRule[] getConditionsOfRule();
        public bool isRuleActive();
        public IActionRule[] getActionsOfRule();
    }

    public interface IConditionRule
    {
        public ComparisonOperatorType getComparisonOperatorType();
        public OperandType getOperandType();
        public LogicCombo getLogicCombo();
        public FuzzyMeasure getЕhresholdLevel();

    }

    public interface IActionRule
    {

    }

    
    public enum ComparisonOperatorType
    {
        GT,
        LT,
        GE,
        LE,
        EQ,
        NE,
        CONTAINS,
        NOTCONTAINS
    }

    public enum OperandType
    {
        INT,
        LONG,
        DATE,
        DECIMAL,
        STRING,
        BOOL,
        FUZZY,
        COMBYLOGIC
    }

    public enum FuzzyMeasure
    {
        DEFINITE_FALSE = 0,
        ZERO = 0,
        TINY = 5,
        WEAK = 10,
        SMALLEST = 15,
        SMALL = 20,
        LOW = 25,
        LESS_THEN = 30,
        MODERATE_LOW_BOUNDARY = 35,
        MIDDLE_LESS_TEN = 40,
        MIDDLE_LESS_FIVE = 45,
        MIDDLE = 50,
        MIDDLE_GREATER_FIVE = 55,
        MIDDLE_GREATER_TEN = 60,
        MODERATE_UPPER_BOUNDARY = 65,
        GREATER_THEN = 70,
        HIGH = 75,
        BIG = 80,
        BIGGEST = 85,
        STRONG = 90,
        HUGE = 95,
        ABSOLUTE = 100,
        DEFINITE_TRUE = 100
    }

    public struct LogicCombo
    {
        public bool booleanLogic;
        public FuzzyMeasure fuzzyLogic;
    }






    public enum LabelType
    {
        OPERATOR_SOURCE_NAME_IN_PROCESSING,

        OPERATOR_SOURCE_UKRTELECOM_REVEALED,
        OPERATOR_SOURCE_KIEVSTAR_REVEALED,
        OPERATOR_SOURCE_VODAFON_REVEALED,
        OPERATOR_SOURCE_UKRTELECOM_PROCESSED,
        OPERATOR_SOURCE_KIEVSTAR_PROCESSED,
        OPERATOR_SOURCE_VODAFON_PROCESSED,


        OPERATOR_SOURCE_UKRTELECOM_PROCESSED_SUCCESFULLY,
        OPERATOR_SOURCE_KIEVSTAR_PROCESSED_SUCCESFULLY,
        OPERATOR_SOURCE_VODAFON_PROCESSED_SUCCESFULLY,

        OPERATOR_SOURCE_UKRTELECOM_PROCESSED_UNSUCCESFULLY,
        OPERATOR_SOURCE_KIEVSTAR_PROCESSED_UNSUCCESFULLY,
        OPERATOR_SOURCE_VODAFON_PROCESSED_UNSUCCESFULLY,

        FIRST_PASS_INITIALIZED,
        FIRST_PASS_PROCESSING,
        FIRST_PASS_PASSED,
        SECOND_PASS_INITIALIZED,
        SECOND_PASS_PROCESSING,
        SECOND_PASS_PASSED,
        THIRD_PASS_INITIALIZED,
        THIRD_PASS_PROCESSING,
        THIRD_PASS_PASSED,

        PARSING_HEAD_OF_XLSX,
        PARCING_BODY_TABLE_OF_XLSX,

        PARCING_HEAD_OF_XLSX_INITIALIZED,
        PARCING_HEAD_OF_XLSX_PASSED,

        PARCING_BODY_TABLE_OF_XLSX_INITIALIZED,
        PARCING_BODY_TABLE_OF_XLSX_PASSED,

        INVOICE_DATE,

        RAW_DOCUMENT_NUMBER_ROW,
        RAW_DOCUMENT_NUMBER_COLUMN,
        RAW_ROW_SPLITTED_INTO_CELLS
    }



    public class LabelOfProcessing
    {
        private bool _iAmActive;

        private long _rawLong;
        private int _rawInt;
        private string _rawString;
        private DateTime _rawDateTime;
        private decimal _rawDecimal;
        private bool _rawBoolean;
        private LogicCombo _logicCombo;

        private LabelType _labelType;

        private OperandType _operandComparisonType;


        public LabelType ThisLabelType  {  set { _labelType = value; }  get => _labelType; }

        public LabelOfProcessing()
        {
            _iAmActive = false;
            _rawLong = 0L;
            _rawInt = 0;
            _rawString = string.Empty;
            _rawDateTime = new DateTime(0);
            _rawDecimal = 0;
            _rawBoolean = false;
            _logicCombo.booleanLogic = false;
            _logicCombo.fuzzyLogic = FuzzyMeasure.DEFINITE_FALSE;
        }

        public LabelOfProcessing(LabelType labelType) : this() => ThisLabelType = labelType;

        public bool AmIActive   {  set { _iAmActive = value;  }  get => _iAmActive;  }




        public string ValueAsString 
        { 
            set 
            {
                _operandComparisonType = OperandType.STRING;
                _rawString = value; 
            } 
            get 
            { 
                if (_operandComparisonType == OperandType.STRING)  return _rawString;
                return null;
            } 
        }
        public long ValueAsLong 
        { 
            set 
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.LONG;
                _rawLong = value;
            }
            get =>  _rawLong;
        }
        public int ValueAsInt
        { 
            set 
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.INT;
                _rawInt = value;
            }
            get =>  _rawInt;
        }
        public DateTime ValueAsDate
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.DATE;
                _rawDateTime = value;
            }
            get  =>  _rawDateTime;
        }
        public decimal ValueAsDecimal
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.DECIMAL;
                _rawDecimal = value;
            }
            get  =>  _rawDecimal;
        }
        public bool ValueAsBool
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.BOOL;
                _rawBoolean = value;

                if (value)
                {
                    _logicCombo.fuzzyLogic = FuzzyMeasure.DEFINITE_TRUE;
                }
                else
                {
                    _logicCombo.fuzzyLogic = FuzzyMeasure.DEFINITE_FALSE;
                }
                _logicCombo.booleanLogic = value;

            }
            get  =>  _rawBoolean;
        }
    }
}


