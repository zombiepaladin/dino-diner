using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {

        /// <summary>
        /// This is the items added
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
            
        /// <summary>
        /// gets the subtotal
        /// </summary>
        public double SubtotalCost { get; }


        /// <summary>
        /// gets the sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }


        /// <summary>
        /// gets the sales tax
        /// </summary>
        public double SalesTaxCost { get; }

        /// <summary>
        /// gets the total cost
        /// </summary>
        public double TotalCost { 
            get
            {
                return SubtotalCost + SalesTaxCost;
            } 
        }

    }
}
