using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{


    /// <summary>
    /// This class is for the TRexKingBurger and is used to setup and modify it
    /// </summary>
    public class TRexKingBurger : Entree, IOrderItem
    {

        

        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        private List<string> ingredients;





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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!pickle) special.Add("Hold Pickles");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if(!lettuce) special.Add("Hold Lettuce");
                if (!mayo) special.Add("Hold Mayo");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");

                return special.ToArray();
            }
        }


        public override double Price
        {
            get
            {
                return 8.45;
            }
        }

        public override uint Calories
        {
            get
            {
                return 728;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                
                List<string> ingredients = new List<string>();
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (ketchup) ingredients.Add("Ketchup");
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }


        }


        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }


        /// <summary>
        /// Sets base price, Calories, and Ingredients for TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie", "Whole Wheat Bun", "Lettuce","Tomato","Onion","Pickle", "Ketchup", "Mustard", "Mayo" };
           
        }
         
        public void HoldBun()
        {
            bun = false;
            this.Ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Lettuce from the TRexKingBurger
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            this.Ingredients.Remove("Lettuce");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Tomato from the TRexKingBurger
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            this.Ingredients.Remove("Tomato");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Onion from the TRexKingBurger
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            this.Ingredients.Remove("Onion");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Pickle from the TRexKingBurger
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            this.Ingredients.Remove("Pickle");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Ketchup from the TRexKingBurger
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            this.Ingredients.Remove("Ketchup");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Mustard from the TRexKingBurger
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            this.Ingredients.Remove("Mustard");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Holds the Mayo from the TRexKingBurger
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            this.Ingredients.Remove("Mayo");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
