using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing an order at a DinoDiner
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        

        /// <summary>
        /// Property determining the Subtotal Cost
        /// </summary>
        private double subtotalcost = 0;

        /// <summary>
        /// Gets the cost of 
        /// </summary>
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

        private double salestaxrate = 0;
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The PropertyChanged event handler, notifies when an order
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A collection of items in the order
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
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

        public Order()
        {
            items = new ObservableCollection<IOrderItem>();
            items.Add(new SteakosaurusBurger());
            items.Add(new Fryceritops());
            Triceritots t = new Triceritots();
            items.Add(t);
            t.Size = Size.Large;
        }

        /// <summary>
        /// Adds a new item to our order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            NotifyAllPropertyChanged();
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertyChanged();
            }
            
            return removed;
            
        }

      
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertyChanged();
        }
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void NotifyAllPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }


    }
}
