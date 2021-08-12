using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class FuzzyValue : IFuzzyValue
    {
        public FuzzyValue()
        {

        }
        public FuzzyValue( bool boolVal)
        {

        }
        public FuzzyValue( int intVal)
        {

        }

        public FuzzyMeasure FuzzyProperty 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public int FuzzyAsIntegerProperty 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public bool FuzzyAsBoolean 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public bool TrueFuzzy => throw new NotImplementedException();


        public override bool Equals( object obj) 
        {

            return false;
        }
        public override int GetHashCode()
        {

            return 0;
        }
    }
}
