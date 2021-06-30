using System;

namespace PM
{
    public class RegisterRecord
    {

        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            RegisterRecord comparedObject = (RegisterRecord)obj;
            if( this.OperatorName != comparedObject.OperatorName || this.TypeOfData != comparedObject.TypeOfData ||
                this.NumberOfPass != comparedObject.NumberOfPass )
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
            return 0;
        }



        public string OperatorName
        {
            get; set;
        }

        public int NumberOfPass
        {
            get; set;
        }

        public string TemplateNameOfFilesChainOfInputData
        {
            get; set;
        }

        public int NumberOfFileInFilesChainOfInputData
        {
            get; set;
        }

        public long NumberOfStringInSourceFileOfInputData
        {
            get; set;
        }

        public int NumberOfColumnInSourceFileOfInputData
        {
            get; set;
        }
        public string NameOfColumnInSourceFileOfInputData
        {
            get; set;
        }

        public OperandType TypeOfData
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
