using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Represents the size of mac&cheese
        /// </summary>
        private Size size;
        /// <summary>
        /// Sets and gets the size of mac/cheese
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 420;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        NotifyIfPropertyChanged("Calories");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        NotifyIfPropertyChanged("Calories");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        NotifyIfPropertyChanged("Calories");
                        break;



                }



            }
            get { return size; }

        }
        /// <summary>
        /// Creates mac and cheese
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            ingredients.Add("Macaroni Noodles");
            ingredients.Add("Cheese Product");
            ingredients.Add("Pork Sausage");

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
            item.Append("Meteor Mac and Cheese");
            return item.ToString();
        }
        

    }
}
