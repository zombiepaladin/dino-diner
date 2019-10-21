using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink, INotifyPropertyChanged
    {
        public bool Lemon { get; set; } = false;

        
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = .1;
                        Calories = 0;
                        break;



                }


                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
            get { return size; }

        }

        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }

        
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ingredients.Add("Water");
            
        }
        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    item.Append("Small ");
                    
                    break;
                case Size.Medium:
                    item.Append("Medium ");
                    
                    break;
                case Size.Large:
                    item.Append("Large ");
                    
                    break;
                default:
                    break;


            }
            item.Append("Water");
            return item.ToString();
        }

        /// <summary>
        /// Returns a string[] of special requests
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon == true) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
