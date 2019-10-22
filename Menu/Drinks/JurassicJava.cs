using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink, INotifyPropertyChanged
    {
        

        private Size size;
        public bool RoomForCream  = false;

        /// <summary>
        /// bool representing decaf
        /// </summary>
        public bool decaf = false;
        
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                if (decaf == true) NotifyIfPropertyChanged("Description");

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
                        Price = .59;
                        Calories = 2;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Special");
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Special");
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Special");
                        break;
                }
            }
            get { return size; }
        }
        public JurassicJava()
        {
            Price = .59;
            Calories = 2;
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            
            NotifyIfPropertyChanged("Special");
        }
        public void AddIce()
        {
            Ice = true;
            
            NotifyIfPropertyChanged("Special");
        }

        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Jurassic Java";
            else return $"{Size} Jurassic Java";
        }


        
        /// <summary>
        /// Special request
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }

        
    }
}