using System.Collections.Generic;
using System.ComponentModel;
using DinoDiner.Menu.Entrees;
/* SteakosaurusBurger.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Represents the existence of bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Represents the existence of pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Represents the existence of ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Represents the existence of mustard
        /// </summary>
        private bool mustard = true;

     
        

        /// <summary>
        /// Initial price and calories of burger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
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
        /// Called when pickle is withheld
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when ketchup is withheld
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when mustard is withheld
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            NotifyIfPropertyChanged("Ingredients");
            NotifyIfPropertyChanged("Special");
        }
        public override string ToString()
        {
            return ("Steakosaurus Burger");
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
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
    }
    }
