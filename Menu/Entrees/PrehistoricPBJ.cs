using System.Collections.Generic;
using DinoDiner.Menu.Entrees;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Represents whether or not peanutButter is added to PBJ
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Represents whether or not jelly is added to PBJ
        /// </summary>
        private bool jelly = true;

        

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special requests
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");

                return special.ToArray();
            }
        }

        

        /// <summary>
        /// Initial price of PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
        }

        /// <summary>
        /// Called when PeanutButter is withheld
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            ingredients.Remove("Peanut Butter");
            NotifyIfPropertyChanged("Special");
            NotifyIfPropertyChanged("Ingredients");
        }
        /// <summary>
        /// Called when jelly is withheld
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            ingredients.Remove("Jelly");
            NotifyIfPropertyChanged("Special");
            NotifyIfPropertyChanged("Ingredients");
        }
        public override string ToString()
        {
            return ("Prehistoric PB&J");
        }
    }
}
