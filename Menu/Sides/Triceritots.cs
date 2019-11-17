using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        /// <summary>
        /// Represents size of tots
        /// </summary>
        private Size size;

       

        /// <summary>
        /// Sets and gets the size of tots
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
                        Calories = 352;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        break;



                }



            }
            get { return size; }

        }
        /// <summary>
        /// Creates tots
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            

        }


        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    item.Append("Small ");
                    NotifyIfPropertyChanged("Description");
                    NotifyIfPropertyChanged("Price");

                    break;
                case Size.Medium:
                    item.Append("Medium ");
                    NotifyIfPropertyChanged("Description");
                    NotifyIfPropertyChanged("Price");
                    break;
                case Size.Large:
                    item.Append("Large ");
                    NotifyIfPropertyChanged("Description");
                    NotifyIfPropertyChanged("Price");
                    break;
                default:
                    break;


            }
            item.Append("Triceritots");
            return item.ToString();
        }
       

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        
        
        }

    }
}