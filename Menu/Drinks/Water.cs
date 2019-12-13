using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/* Water.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// tracks whether lemon exists
        /// </summary>
        public bool lemon = false;

        /// <summary>
        /// private backing field
        /// </summary>
        private Size size;
        public override string Type
        {
            get
            {
                return "Jurrasic Java";
            }
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


                NotifyIfPropertyChanged("Description");
                NotifyIfPropertyChanged("Price");
                NotifyIfPropertyChanged("Calories");
            }
            get { return size; }

        }

        public void AddLemon()
        {
            lemon = true;
            ingredients.Add("Lemon");
            NotifyIfPropertyChanged("Special");
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
                if (lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
