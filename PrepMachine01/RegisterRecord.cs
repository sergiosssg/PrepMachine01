using System;

namespace PM
{

    public interface IRecord : IKODEItem, IOperandTypeItem, IRawdataItem, INettodataItem
    {

    }


    public class RegisterRecord : IRecord
    {

        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            RegisterRecord comparedObject = (RegisterRecord)obj;
            if( !this.OperatorName.Equals( comparedObject.OperatorName) || this.TypeOfData != comparedObject.TypeOfData ||
                this.PassNumbes != comparedObject.PassNumbes)
            {
                return false;
            }
            if( this.TemplateNameOfFilesChainOfInputData != string.Empty && comparedObject.TemplateNameOfFilesChainOfInputData != string.Empty &&
                !this.TemplateNameOfFilesChainOfInputData.Equals( comparedObject.TemplateNameOfFilesChainOfInputData) &&
                this.NumberOfFileInFilesChainOfInputData != comparedObject.NumberOfFileInFilesChainOfInputData)
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

            this.TypeOfData.GetHashCode();

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

        public string TemplateNameOfFilesChainOfInputData
        {
            get; set;
        }

        public int NumberOfFileInFilesChainOfInputData
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
