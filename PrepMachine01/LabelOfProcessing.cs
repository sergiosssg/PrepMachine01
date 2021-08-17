using System;

namespace PM
{
    public class LabelOfProcessing : IValueOfProcessing
    {
        private bool _iAmActive;

        private long _rawLong;
        private int _rawInt;
        private string _rawString;
        private DateTime _rawDateTime;
        private decimal _rawDecimal;
        private bool _rawBoolean;
        private IFuzzyValue _fuzzyLogic;
        private string _nettoData;

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
            _fuzzyLogic = new FuzzyValue();
            _operandComparisonType = OperandType.INT;
        }

        public LabelOfProcessing(LabelType labelType) : this() => ThisLabelType = labelType;

        public bool AmIActive   {  set { _iAmActive = value;  }  get => _iAmActive;  }


        public OperandType ComparisonOperandType
        {
            get
            {
                return _operandComparisonType;
            }
            set
            {
                _operandComparisonType = value;
            }
        }

        public override bool Equals(object obj)
        {
            if( ( obj == null  ) || (obj.GetType() != this.GetType()))
            {
                return false;
            }

            LabelOfProcessing objLabelOfProcessing = (LabelOfProcessing)obj;

            if (this._operandComparisonType != objLabelOfProcessing._operandComparisonType)
            {
                return false;
            }

            if(( this._operandComparisonType == OperandType.BOOL ) && ( this._rawBoolean == objLabelOfProcessing._rawBoolean ))
            {
                return true;
            }
            else if((this._operandComparisonType == OperandType.COMBYLOGIC) && 
                (this._fuzzyLogic == objLabelOfProcessing._fuzzyLogic))
            {
                return true;
            }else if((this._operandComparisonType == OperandType.STRING) && (this._rawString.Equals(objLabelOfProcessing._rawString)))
            {
                return true;
            }else if((this._operandComparisonType == OperandType.INT) && (this._rawInt == objLabelOfProcessing._rawInt))
            {
                return true;
            }else if((this._operandComparisonType == OperandType.DATE) && (this._rawDateTime == objLabelOfProcessing._rawDateTime))
            {
                return true;
            }else if((this._operandComparisonType == OperandType.DECIMAL) && (this._rawDecimal == objLabelOfProcessing._rawDecimal))
            {
                return true;
            }else if((this._operandComparisonType == OperandType.FUZZY) && (this._fuzzyLogic == objLabelOfProcessing._fuzzyLogic))
            {
                return true;
            }else if((this._operandComparisonType == OperandType.LONG) && (this._rawLong == objLabelOfProcessing._rawLong))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {


            return 0;
        }


        public string ValueAsString 
        { 
            set 
            {
                _operandComparisonType = OperandType.STRING;
                _nettoData = _rawString = value;
            } 
            get 
            { 
                if (_operandComparisonType == OperandType.STRING)  return _rawString;
                return string.Empty;
            } 
        }
        public long ValueAsLong 
        { 
            set 
            {
                _rawString = string.Empty;
                _nettoData = "" + value;
                _operandComparisonType = OperandType.LONG;
                _rawLong = value;
            }
            get =>  _rawLong;
        }
        public int ValueAsInt
        { 
            set 
            {
                _rawString = string.Empty;
                _nettoData = "" + value;
                _operandComparisonType = OperandType.INT;
                _rawInt = value;
            }
            get =>  _rawInt;
        }
        public DateTime ValueAsDate
        {
            set
            {
                _rawString = string.Empty;
                _nettoData = "" + value;
                _operandComparisonType = OperandType.DATE;
                _rawDateTime = value;
            }
            get  =>  _rawDateTime;
        }
        public decimal ValueAsDecimal
        {
            set
            {
                _rawString = string.Empty;
                _nettoData = "" + value;
                _operandComparisonType = OperandType.DECIMAL;
                _rawDecimal = value;
            }
            get  =>  _rawDecimal;
        }
        public bool ValueAsBool
        {
            set
            {
                _rawString = string.Empty;
                _nettoData = "" + value;
                _operandComparisonType = OperandType.BOOL;
                _rawBoolean = value;

                _fuzzyLogic = new FuzzyValue(value);
            }
            get  =>  _rawBoolean;
        }

        public string NettoData { get => _nettoData; }
    }
}


