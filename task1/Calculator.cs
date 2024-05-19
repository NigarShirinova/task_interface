using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    
    internal class Calculator : ICalculator
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public Calculator(int num1, int num2)
        {
            NumberTwo = num2;
            NumberOne = num1;
        }
        public int CalculateDivision()
        {
            return NumberOne/NumberTwo;
        }

        public int CalculateSubstraction()
        {
            return NumberOne - NumberTwo; 
        }

        public int CalculateSum()
        {
            return NumberOne + NumberTwo;
        }

        public int CalcutateMultipication()
        {
            return NumberOne * NumberTwo;
        }
    }
}
