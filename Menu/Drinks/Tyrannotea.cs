using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/* Tyrannotea.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink, INotifyPropertyChanged
    {
       

        public bool lemon  = false;

        public bool Sweet = false;

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


                NotifyIfPropertyChanged("Description");
                NotifyIfPropertyChanged("Price");
            }
            get { return size; }


        }

        public void AddLemon()
        {
            lemon = true;
            ingredients.Add("Lemon");
            NotifyIfPropertyChanged("Special");
        }

        public void AddSweet()
        {
            Sweet = true;
            ingredients.Add("Sugar");
            NotifyIfPropertyChanged("Description");
        }

        
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;

            ingredients.Add("Water");
            ingredients.Add("Tea");



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
        /// special requests
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
