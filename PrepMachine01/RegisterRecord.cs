using System;

namespace PM
{
    public class RegisterRecord
    {
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
