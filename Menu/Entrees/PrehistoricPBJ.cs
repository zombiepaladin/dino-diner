 using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{



    
    /// <summary>
    /// This class is for the PrehistoricPBJ and is used to setup and modify it
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged, IOrderItem
    {


        private bool bun = true;
        private bool peanutButter = true;
        private bool jelly = true;
        private List<string> ingredients;

        // <summary>
        /// gets and sets the description
        /// </summary>
        public string Description

        {

            get
            {
                return  this.ToString();
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
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");

                return special.ToArray();
            }
        }

        public override double Price
        {
            get
            {
                return 6.52;
            }
        }

        public override uint Calories
        {
            get
            {
                return 483;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Bread");
                
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
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
            
           
            ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
        }
        /// <summary>
        /// Holds the Peanut Butter from the PrehistoricPBJ
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
            this.Ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Jelly from the PrehistoricPBJ
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
            this.Ingredients.Remove("Jelly");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
