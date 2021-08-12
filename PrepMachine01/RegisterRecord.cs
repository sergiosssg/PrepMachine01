using System;

namespace PM
{
    public class RegisterRecord : IRecord, IValueOfProcessing, ITableIndicators, ISourceFilesChainsItem, IOperatorItem, IProcessingPassItem
    {

        private long _rawLong;
        private int _rawInt;
        private string _rawString;
        private DateTime _rawDateTime;
        private decimal _rawDecimal;
        private bool _rawBoolean;
        private IFuzzyValue _fuzzyLogic;

        private OperandType _operandComparisonType;

        public string ValueAsString
        {
            set
            {
                _operandComparisonType = OperandType.STRING;
                _rawString = value;
            }
            get
            {
                if (_operandComparisonType == OperandType.STRING) return _rawString;
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
            get => _rawLong;
        }
        public int ValueAsInt
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.INT;
                _rawInt = value;
            }
            get => _rawInt;
        }
        public DateTime ValueAsDate
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.DATE;
                _rawDateTime = value;
            }
            get => _rawDateTime;
        }
        public decimal ValueAsDecimal
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.DECIMAL;
                _rawDecimal = value;
            }
            get => _rawDecimal;
        }
        public bool ValueAsBool
        {
            set
            {
                _rawString = "" + value;
                _operandComparisonType = OperandType.BOOL;
                _rawBoolean = value;

                _fuzzyLogic = new FuzzyValue(value);
            }
            get => _rawBoolean;
        }




        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            RegisterRecord comparedObject = (RegisterRecord)obj;
            if( !this.OperatorName.Equals( comparedObject.OperatorName) || this.ComparisonOperandType != comparedObject.ComparisonOperandType ||
                this.PassNumbes != comparedObject.PassNumbes)
            {
                return false;
            }
            if( this.FileNameTemplate != string.Empty && comparedObject.FileNameTemplate != string.Empty &&
                !this.FileNameTemplate.Equals( comparedObject.FileNameTemplate) &&
                this.OrderNumberInChain != comparedObject.OrderNumberInChain)
            {
                return false;
            }
            if( this.RowNumber != comparedObject.RowNumber &&
                this.ColumnNumber != comparedObject.ColumnNumber)
            {
                return false;
            }
            if( this.ColumnName != string.Empty && comparedObject.ColumnName != string.Empty &&
                !this.ColumnName.Equals( comparedObject.ColumnName))
            {
                return false;
            }


            if(( this.NettoData != string.Empty && comparedObject.NettoData != string.Empty ) &&
                 this.NettoData.Equals(comparedObject.NettoData))
            {
                return true;
            }
            return false;
        }


        public override int GetHashCode()
        {

            this.ComparisonOperandType.GetHashCode();

            return 0;
        }


        /**
         *  unique provided by date estamp and MAC addres then bited shifted to left for eight bit and then accumulated here
         * 
         */
        public long KODE
        {
            get; set;
        }



        public string OperatorName
        {
            get; set;
        }

        public int PassNumbes
        {
            get; set;
        }

        public string FileNameTemplate
        {
            get; set;
        }

        public int OrderNumberInChain
        {
            get; set;
        }

        public long RowNumber
        {
            get; set;
        }

        // NumberOfColumnInSourceFileOfInputData
        public int ColumnNumber
        {
            get; set;
        }

        // NameOfColumnInSourceFileOfInputData
        public string ColumnName
        {
            get; set;
        }





        public OperandType ComparisonOperandType
        {
            get; set;
        }

        ///
        //// reference for semantic tuple
        ///

        public byte[] RawData
        {
            get; set;
        }

        public string NettoData
        {
            get; set;
        }
    }

}
