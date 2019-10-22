
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/*Brontowurst.cs
 * Author: Thomas Paul
 */

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Represents the existence of bun 
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Represents the existence of peppers
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Represents the existence of onions
        /// </summary>
        private bool onions = true;

        


        

        /// <summary>
        /// Initial price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        /// <summary>
        /// Called when bun is withheld
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when peppers are withheld
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            ingredients.Remove("Peppers");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when onions are withheld
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            ingredients.Remove("Onion");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }

        /// <summary>
        /// returns Entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Brontowurst");
        }

        /// <summary>
        /// Returns a string[] of special requests
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!onions) special.Add("Hold Onion");
                if (!peppers) special.Add("Hold Peppers");
                return special.ToArray();
            }
        }
    }
}
