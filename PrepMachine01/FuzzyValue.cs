using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public class FuzzyValue : IFuzzyValue
    {
        private FuzzyMeasure _fuzzyValue;

        public FuzzyValue()
        {
            _fuzzyValue = FuzzyMeasure.ZERO;
        }
        public FuzzyValue(bool boolVal)
        {
            if (boolVal)
            {
                _fuzzyValue = FuzzyMeasure.ABSOLUTE;
            }
            else
            {
                _fuzzyValue = FuzzyMeasure.ZERO;
            }
        }
        public FuzzyValue(int intVal)
        {

        }

        public FuzzyMeasure FuzzyProperty
        {
            get => _fuzzyValue;
            set => _fuzzyValue = value;
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

        public bool TrueFuzzy 
        {
            get
            {
                if(_fuzzyValue == FuzzyMeasure.ZERO || _fuzzyValue == FuzzyMeasure.DEFINITE_FALSE || _fuzzyValue == FuzzyMeasure.ABSOLUTE || _fuzzyValue == FuzzyMeasure.DEFINITE_TRUE)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool ANDoperation(bool operand)
        {
            throw new NotImplementedException();
        }

        public IFuzzyValue Conjunction(IFuzzyValue operand)
        {
            throw new NotImplementedException();
        }

        public IFuzzyValue Disjunction(IFuzzyValue operand)
        {
            throw new NotImplementedException();
        }

        public override bool Equals( object obj) 
        {

            return false;
        }
        public override int GetHashCode()
        {

            return 0;
        }

        public bool NOToperation()
        {
            throw new NotImplementedException();
        }

        public bool ORoperation(bool operand)
        {
            throw new NotImplementedException();
        }
    }
}
