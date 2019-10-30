using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{


    /// <summary>
    /// This class is for the SteakosaurusBurger and is used to setup and modify it
    /// </summary>
    public class SteakosaurusBurger : Entree, IOrderItem
    {

       
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private List<string> ingredients;





        public string Description
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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!pickle) special.Add("Hold Pickles");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");

                return special.ToArray();
            }
        }


        public override double Price
        {
            get
            {
                return 5.15;
            }
        }

        public override uint Calories
        {
            get
            {
                return 621;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (ketchup) ingredients.Add("Ketchup");
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }


        }

        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
        /// <summary>
        /// Sets base price, Calories, and Ingredients for SteakosaurusBurger
        /// </summary>
        public SteakosaurusBurger()
        {
           
            ingredients = new List<string>() { "Steakburger Pattie", "Whole Wheat Bun", "Pickle", "Ketchup", "Mustard" };
          
        }
        /// <summary>
        /// Holds the bun from the SteakosaurusBurger
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            this.Ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Pickle from the SteakosaurusBurger
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            this.Ingredients.Remove("Pickle");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Ketchup from the SteakosaurusBurger
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;

            this.Ingredients.Remove("Ketchup");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Mustard from the SteakosaurusBurger
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            this.Ingredients.Remove("Mustard");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
