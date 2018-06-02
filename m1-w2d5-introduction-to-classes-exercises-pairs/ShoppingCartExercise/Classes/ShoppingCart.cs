using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        private int totalNumberOfItem;
        private decimal totalAmountOwed;

        public int TotalNumberOfItem
        {
            get
            {
                return totalNumberOfItem;
            }
        }

        public decimal TotalAmountOwed
        {
            get
            {
                return totalAmountOwed;
            }
        }


        public decimal GetAveragePricePerItem(int totalNumberOfItem, decimal totalAmountOwed)
        {
            return totalAmountOwed / totalNumberOfItem;
        }

        public void AddItems(int numberOfItem, decimal pricePerItem)
        {
            totalAmountOwed = TotalAmountOwed + (pricePerItem * numberOfItem);
            //readme says "(T)otalAmountOwed"
        }

        public void Empty()
        {
            totalNumberOfItem = 0;
            totalAmountOwed = 0;
            //readme says "(T)otalAmountOwed & (T)otalNumberOfItems"
        }

    }
}
