using System.Collections.Generic;
using System.ComponentModel;
using DinoDiner.Menu.Entrees;
/* TRexKingBurger.cs
 * Author: Thomas Paul
 */

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree, INotifyPropertyChanged
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
        /// Represents the existence of lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Represents the existence of onion
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Represents the existence of mayo
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// Represents the existence of tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// An event handler for PropertyChanged events for Price, Calories, and Specials
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

        /// <summary>
        /// Price and Calories of T-Rex Burger
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Onion");
            ingredients.Add("Tomato");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }
        /// <summary>
        /// Called when bun is withheld
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when lettuce is withheld
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when tomato is witheld
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            ingredients.Remove("Tomato");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when onion is withheld
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when pickle is withheld
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when ketchup is witheld
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when mustrard is withheld
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Called when mayo is withheld
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            ingredients.Remove("Mayo");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return ("T-Rex King Burger");
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!onion) special.Add("Hold Onion");
                if (!tomato) special.Add("Hold Tomato");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
    }
}

