using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class FuzzyValue : IFuzzyValue
    {
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
    }
}
