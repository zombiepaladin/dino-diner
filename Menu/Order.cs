using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        double salesTaxRate = 0;
        List<IOrderItem> items = new List<IOrderItem>();



        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        


        /// <summary>
        /// This is the items added
        /// </summary>
        public IOrderItem[] Items {
            get
            {
                return items.ToArray();
            }
        }
            
        /// <summary>
        /// gets the subtotal
        /// </summary>
        public double SubtotalCost {
            get
            {
                double total = 0;
                foreach (IOrderItem item in Items)
                {
                    total += item.Price;
                }

                return total;

            }




        }
                


        /// <summary>
        /// gets the sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }


        /// <summary>
        /// gets the sales tax
        /// </summary>
        public double SalesTaxCost { get
            {
                return salesTaxRate;

            }
            set
            {
                if (value < 0) return;
                salesTaxRate = value;
                NotifyAllPropertyChanged();

            }
            }

        /// <summary>
        /// gets the total cost
        /// </summary>
        public double TotalCost { 
            get
            {
                return SubtotalCost + SalesTaxCost;
            } 
        }

        public Order()
        {

            items = new List<IOrderItem>();
            Add(new SteakosaurusBurger());
            Add(new Fryceritops());
            Triceritots t = new Triceritots();
            Add(t);
            t.Size = Size.Large;

        }

        protected void NotifyAllPropertyChanged()
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("totalCost"));
        }

        /// <summary>
        /// Adds a new item to our order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertyChanged();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            NotifyAllPropertyChanged();
        }

    }
}
