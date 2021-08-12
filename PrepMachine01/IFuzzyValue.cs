using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface IFuzzyValue
    {
        public FuzzyMeasure FuzzyProperty
        {
            get;
            set;
        }

        public int FuzzyAsIntegerProperty
        {
            get;
            set;
        }

        public bool FuzzyAsBoolean
        {
            get;
            set;
        }

        public bool TrueFuzzy
        {
            get;
        }
    }
}
