using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Property determining the Subtotal Cost
        /// </summary>
        private double subtotalcost = 0;
        public double SubtotalCost
        {

            get
            {
                
                foreach(IOrderItem i in Items)
                {
                    subtotalcost += i.Price;
                }
                if(subtotalcost < 0)
                {
                    subtotalcost = 0;
                }

                return subtotalcost;
            }

        }

        private double salestaxrate;
        public double SalesTaxRate { get { return salestaxrate; } protected set { salestaxrate = .065; } }

        public double SalesTaxCost
        {
            get
            {
                return (SalesTaxRate * SubtotalCost);
            }
        }

        /// <summary>
        /// Property
        /// </summary>
        public double TotalCost {
            get
            {
                return (SubtotalCost + SalesTaxCost);
            }

        }
    }
}
