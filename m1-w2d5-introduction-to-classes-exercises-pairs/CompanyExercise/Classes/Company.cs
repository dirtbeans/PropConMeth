using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        //private instance variables
        private string nameOfCompany;
        private int numberOfEmployees;
        private decimal revenue;
        private decimal expenses;

        //constructors
        public Company()
        {
            nameOfCompany = "Name";
        }
        /*
        public Company(string startingName)
        {
            nameOfCompany = "Name";
        }
        */
        //properties

        public string NameOfCompany
        {
            get
            {
                return nameOfCompany;
            }
        }

        public int NumberOfEmployees
        {
            get
            {
                return numberOfEmployees;
            }
            set
            {
                if (value > 0)
                {
                    numberOfEmployees = value;
                }
                else
                {
                    numberOfEmployees = 0;
                }
            }
        }

        public decimal Revenue
        {
            get
            {
                return revenue;
            }
            set
            {
                if (value > 0)
                {
                    revenue = value;
                }
                else
                {
                    revenue = 0;
                }
            }
        }

        public decimal Expenses
        {
            get
            {
                return expenses;
            }
            set
            {
                if (value > 0)
                {
                    expenses = value;
                }
                else
                {
                    expenses = 0;
                }
            }
        }

        //methods
        public decimal Subtract(decimal revenue, decimal expenses)
        {

            return revenue - expenses;
        }

        public string Size(int numberOfEmployees)
        {
            if (numberOfEmployees < 50)
            {
                return "small";
            }
            else if (numberOfEmployees > 50 && numberOfEmployees < 250)
            {
                return "medium";
            }
            else if (numberOfEmployees > 250)
            {
                return "large";
            }
            else
                return "enter valid number";
        }

    }
}
