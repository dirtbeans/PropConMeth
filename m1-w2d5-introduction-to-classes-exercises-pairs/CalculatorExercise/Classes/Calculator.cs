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
            result = startingResult;
        }

        public int Result
        {
            get
            {
                return result;
            }
        }

        public int Add(int addend)
        {
            result = Result + addend;
            return result;
            //Readme says (R)esult
        }

        public int Subtract(int subtrahend)
        {
            result = Result - subtrahend;
            return result;
            //Readme says (R)esult
        }

        public int Multipy(int multiplier)
        {
            result = Result * multiplier;
            return result;
            //Readme says (R)esult
        }

        public int Power(int exponent)
        {
            for (int i = 0; i <= exponent; i++)
            {
                result = result * result;
            }
            return result;
            //Readme says (R)esult
        }

        public void Reset()
        {
            result = 0;
            //Readme says (R)esult
        }
    }
}
