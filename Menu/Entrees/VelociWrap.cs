using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{


    /// <summary>
    /// This class is for the VelociWrap and is used to setup and modify it
    /// </summary>
    public class VelociWrap : Entree, IOrderItem
    {
        

        private bool tortilla = true;
        private bool chicken = true;
        private bool lettuce = true;
        private bool ceasar = true;
        private bool parm = true;
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
                if (!tortilla) special.Add("Hold Flour Tortilla");
                if (!lettuce) special.Add("Hold Romaine Lettuce");
                if (!ceasar) special.Add("Hold Ceasar Dressing");
                if (!parm) special.Add("Hold Parmesan Cheese");
               

                return special.ToArray();
            }
        }



        public override double Price
        {
            get
            {
                return 6.86;
            }
        }

        public override uint Calories
        {
            get
            {
                return 356;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                ingredients.Add("Romaine Lettuce");
                ingredients.Add("Ceasar Dressing");
               if(parm) ingredients.Add("Parmesan Cheese");
                
                return ingredients;
            }


        }

        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Sets base price, Calories, and Ingredients for VelociWrap
        /// </summary>
        public VelociWrap()
        {
         
            ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce", "Ceasar Dressing", "Parmesan Cheese" };
           
        }
        /// <summary>
        /// Used to hold the dressing
        /// </summary>
        public void HoldDressing()
        {
            ceasar = false;
            this.Ingredients.Remove("Ceasar Dressing");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Used to Hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            this.Ingredients.Remove("Romaine Lettuce");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Used to hold the cheese
        /// </summary>
        public void HoldCheese()
        {
            parm = false;
            Ingredients.Remove("Parmesan Cheese");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
