using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Represents size of tots
        /// </summary>
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// tracks when property event is changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
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
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");

        }


        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    item.Append("Small ");
                    NotifyOfPropertyChanged("Description");
                    NotifyOfPropertyChanged("Price");

                    break;
                case Size.Medium:
                    item.Append("Medium ");
                    NotifyOfPropertyChanged("Description");
                    NotifyOfPropertyChanged("Price");
                    break;
                case Size.Large:
                    item.Append("Large ");
                    NotifyOfPropertyChanged("Description");
                    NotifyOfPropertyChanged("Price");
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
    }
}