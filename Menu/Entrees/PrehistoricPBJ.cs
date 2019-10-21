using System.Collections.Generic;
using DinoDiner.Menu.Entrees;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
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
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and 
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Called when jelly is withheld
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            ingredients.Remove("Jelly");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return ("Prehistoric PB&J");
        }
    }
}
