using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        private int result;

        public Calculator(int startingResult)
        {
            Result = startingResult;
            //Caps?
        }

        public int Result
        {
            get
            {
                return result;
            }
            private set
            {
                result = value;
            }
        }

        public int Add(int addend)
        {
            Result = Result + addend;
            return Result;
            //Readme says (R)esult
        }

        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;
            //Readme says (R)esult
        }

        public int Multiply(int multiplier)
        {
            Result = Result * multiplier;
            return Result;
            //Readme says (R)esult
        }

        public int Power(int exponent)
        {
            if (exponent<0)
            {
                exponent = exponent * (-1);
            }

            
            Result = (int)Math.Pow(Result, exponent); 
            
                return Result;
            
            //Readme says (R)esult
        }

        public void Reset()
        {
            result = 0;
            //Readme says (R)esult
        }
    }
}
