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

        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        


        /// <summary>
        /// This is the items added
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
            
        /// <summary>
        /// gets the subtotal
        /// </summary>
        public double SubtotalCost {
            get
            {
                foreach (IOrderItem order in Items)
                {
                    return 1;
                }

                return 1;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

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

            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;

            Items.Add(new SteakosaurusBurger());
            Items.Add(new Fryceritops());
            Triceritots t = new Triceritots();
            Items.Add(t);
            t.Size = Size.Large;

        }


        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

    }
}
