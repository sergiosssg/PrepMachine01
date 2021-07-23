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
            if( !this.OperatorName.Equals( comparedObject.OperatorName) || this.TypeOfData != comparedObject.TypeOfData ||
                this.NumberOfPass != comparedObject.NumberOfPass)
            {
                return false;
            }
            if( this.TemplateNameOfFilesChainOfInputData != string.Empty && comparedObject.TemplateNameOfFilesChainOfInputData != string.Empty &&
                !this.TemplateNameOfFilesChainOfInputData.Equals( comparedObject.TemplateNameOfFilesChainOfInputData) &&
                this.NumberOfFileInFilesChainOfInputData != comparedObject.NumberOfFileInFilesChainOfInputData)
            {
                return false;
            }
            if( this.NumberOfStringInSourceFileOfInputData != comparedObject.NumberOfStringInSourceFileOfInputData &&
                this.NumberOfColumnInSourceFileOfInputData != comparedObject.NumberOfColumnInSourceFileOfInputData)
            {
                return false;
            }
            if( this.NameOfColumnInSourceFileOfInputData != string.Empty && comparedObject.NameOfColumnInSourceFileOfInputData != string.Empty &&
                !this.NameOfColumnInSourceFileOfInputData.Equals( comparedObject.NameOfColumnInSourceFileOfInputData))
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

            this.TypeOfData.GetHashCode();

            return 0;
        }


        /**
         *  unique provided by date estamp and MAC addres then ...
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
