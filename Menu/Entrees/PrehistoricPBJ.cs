 using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{



    
    /// <summary>
    /// This class is for the PrehistoricPBJ and is used to setup and modify it
    /// </summary>
    public class PrehistoricPBJ : Entree , INotifyPropertyChanged
    {

        private bool penutButter = true;
        private bool jelly = true;

        /// <summary>
        /// gets and sets the description
        /// </summary>
        public string Discription
        {

            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// PropertyChanged event handeler; notifys of changes to the Price,Description,and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        //Helper Function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets any special preperatoin instruction
        /// </summary>
        public string[] Special
        {

            get
            {
                List<string> special = new List<string>();
                if (!penutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Sets base price, Calories, and Ingredients for PrehistoricPBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            this.Ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
        }
        /// <summary>
        /// Holds the Peanut Butter from the PrehistoricPBJ
        /// </summary>
        public void HoldPeanutButter()
        {
            this.Ingredients.Remove("Peanut Butter");
            this.penutButter = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Jelly from the PrehistoricPBJ
        /// </summary>
        public void HoldJelly()
        {
            this.Ingredients.Remove("Jelly");
            this.jelly = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
