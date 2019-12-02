using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Represents the size of mezzorella sticks
        /// </summary>
        private Size size;


        /// <summary>
        /// Gets and sets the size of mezzorella sticks
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        NotifyIfPropertyChanged("Calories");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        NotifyIfPropertyChanged("Calories");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        NotifyIfPropertyChanged("Calories");
                        break;



                }



            }
            get { return size; }

        }

        /// <summary>
        /// Creates the mezzorella sticks
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            ingredients.Add("Cheese Product");
            ingredients.Add("Breading");
            ingredients.Add("Vegetable Oil");

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
            item.Append("Mezzorella Sticks");
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
                return special.ToArray();
            }
        }

    }
}
