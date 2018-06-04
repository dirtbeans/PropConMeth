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
        private int totalNumberOfItems;
        private decimal totalAmountOwed;

        public int TotalNumberOfItems
        {
            get
            {
                return totalNumberOfItems;
            }
            private set
            {
                totalNumberOfItems = value;
            }
        }

        public decimal TotalAmountOwed
        {
            get
            {
                return totalAmountOwed;
            }
            private set
            {
                totalAmountOwed = value;
            }
        }


        public decimal GetAveragePricePerItem()
        {
            if(TotalNumberOfItems==0)
            {
                return 0M;
            }
            return TotalAmountOwed / TotalNumberOfItems;
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            TotalAmountOwed = TotalAmountOwed + (pricePerItem * numberOfItems);
            TotalNumberOfItems = TotalNumberOfItems + numberOfItems;
        }

        public void Empty()
        {
            TotalNumberOfItems = 0;
            TotalAmountOwed = 0;
        }

    }
}
