using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Represents the existence of dressing
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Represents the existence of lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Represents the existence of cheese
        /// </summary>
        private bool cheese = true;

        

       

        /// <summary>
        /// Initial price and calories of wrap
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }
        /// <summary>
        /// Called when dressing is withheld
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            ingredients.Remove("Ceasar Dressing");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when lettuce is withheld
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Romaine Lettuce");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when cheese is withheld
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            ingredients.Remove("Parmesan Cheese");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        public override string ToString()
        {
            return ("Veloci-Wrap");
        }

        /// <summary>
        /// Returns a string[] of special requests
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Hold Ceasar Dressing");
                if (!lettuce) special.Add("Hold Romaine Lettuce");
                if (!cheese) special.Add("Hold Parmesan Cheese"); ;
                return special.ToArray();
            }
        }
    }
    }
