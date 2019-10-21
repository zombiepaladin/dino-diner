using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink, INotifyPropertyChanged
    {

        

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// tracks change in property
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Lemon { get; set; } = false;

        public bool Sweet { get; set; } = false;

        /// <summary>
        /// private backing variable
        /// </summary>
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        if (Sweet) Calories = 16;
                        else Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet) Calories = 32;
                        else Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        if (Sweet) Calories = 64;
                        else Calories = 32;
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
            ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Special");
        }
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            
            if (Lemon) Ingredients.Add("Lemon");
            if (Sweet)
            {
                Ingredients.Add("Cane Sugar");
                
            }
           


        }
        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    item.Append("Small ");
                    if (Sweet)
                    {
                        item.Append("Sweet ");
                    }
                    break;
                case Size.Medium:
                    item.Append("Medium ");
                    if (Sweet)
                    {
                        item.Append("Sweet ");
                    }
                    break;
                case Size.Large:
                    item.Append("Large ");
                    if (Sweet)
                    {
                        item.Append("Sweet ");
                    }
                    break;
                default:
                    break;


            }
            item.Append("Tyrannotea");
            return item.ToString();

        }
        

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
