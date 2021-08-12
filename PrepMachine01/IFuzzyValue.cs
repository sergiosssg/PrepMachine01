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
            set;
        }

        public bool TrueFuzzy
        {
            get;
        }

        public bool NOToperation();

        public bool ANDoperation(bool operand);

        public bool ORoperation(bool operand);

        public IFuzzyValue Conjunction(IFuzzyValue operand);

        public IFuzzyValue Disjunction(IFuzzyValue operand);
    }
}
