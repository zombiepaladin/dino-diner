using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{

    /// <summary>
    /// THis class is for the brawtwurst and is used to setup and modify it
    /// </summary>
    public class Brontowurst : Entree , IOrderItem, INotifyPropertyChanged
    {


        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
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
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onions");

                return special.ToArray();
            }
        }


        public override double Price
        {
            get
            {
                return 5.36;
            }
        }

        public override uint Calories
        {
            get
            {
                return 498;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Brautwurst");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
          

        }




        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
        /// <summary>
        /// Sets base price, Calories, and Ingredients for Brontowurst
        /// </summary>
        public Brontowurst()
        {


            ingredients = new List<string>() { "Fish Patty", "Whole Wheat Bun", "Mayonnaise" };
        }

        /// this is used to hold the item
        public void HoldBun()
        {
            this.bun = false;
            this.Ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// this is used to hold the item
        public void HoldOnion()
        {
            this.onions = false;
            this.Ingredients.Remove("Onion");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// this is used to hold the item
        public void HoldPeppers()
        {
            this.peppers = false;
            this.Ingredients.Remove("Peppers");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
