using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IRule
    {

    }

    public interface IConditionRule
    {

    }

    public interface IActionRule
    {

    }

/*
    public interface ILabelOfPrecessing
    {
        public LabelType getThisLabelType();
        public string getValueAsString();
        public long getValueAsLong();
        public int getValueAsInt();
        public DateTime getValueAsDate();
        public decimal getValueAsDecimal();
        public bool getValueAsBool();
        public bool isLabelActive();
        public void setAsPassive();

    }
*/
    
    public enum ComparisonOperatorType
    {
        GT,
        LT,
        GE,
        LE,
        EQ,
        NE
    }

    public enum OperandComparisonType
    {
        INT,
        LONG,
        DATE,
        DECIMAL,
        STRING,
        BOOL
    }




    public enum LabelType
    {
        OPERATOR_SOURCE_NAME, 
        FIRST_PASS_INITIALIZED, 
        FIRST_PASS_PASSED,
        SECOND_PASS_INITIALIZED,
        SECOND_PASS_PASSED,
        THIRD_INITIALIZED,
        THIRD_PASSED,
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



    public class LabelOfPrecessing
    {
        private bool _iAmActive;

        private long _rawLong;
        private int _rawInt;
        private string _rawString;
        private DateTime _rawDateTime;
        private decimal _rawDecimal;
        private bool _rawBoolean;

        private LabelType _labelType;

        private OperandComparisonType _operandComparisonType;


        public LabelType ThisLabelType  {  set { _labelType = value; }  get{ return _labelType;  } }


        public string ValueAsString 
        { 
            set 
            {
                _operandComparisonType = OperandComparisonType.STRING;
                _rawString = value; 
            } 
            get 
            { 
                if (_operandComparisonType == OperandComparisonType.STRING)  return _rawString;
                return null;
            } 
        }
        public long ValueAsLong 
        { 
            set 
            {
                _rawString = "" + value;
                _operandComparisonType = OperandComparisonType.LONG;
                _rawLong = value;
            }
            get 
            {
                return _rawLong;
            }
        }
        public int ValueAsInt
        { 
            set 
            {
                _rawString = "" + value;
                _operandComparisonType = OperandComparisonType.INT;
                _rawInt = value;
            }
            get 
            {
                return _rawInt;
            }
        }
        public DateTime ValueAsDate
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandComparisonType.DATE;
                _rawDateTime = value;
            }
            get
            {
                return _rawDateTime;
            }
        }
        public decimal ValueAsDecimal
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandComparisonType.DECIMAL;
                _rawDecimal = value;
            }
            get
            {
                return _rawDecimal;
            }
        }
        public bool ValueAsBool
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandComparisonType.BOOL;
                _rawBoolean = value;
            }
            get
            {
                return _rawBoolean;
            }
        }
    }
}


