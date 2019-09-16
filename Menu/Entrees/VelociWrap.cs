using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{


    /// <summary>
    /// This class is for the VelociWrap and is used to setup and modify it
    /// </summary>
    public class VelociWrap
    {
        private bool flourTortilla = true;
        private bool chickenBreast = true;
        private bool romaineLettuce = true;
        private bool ceasarDressing = true;
        private bool parmesanCheese = true;



        /// <summary>
        /// gets and sets price and calories
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }



        // this is the list of Ingredients
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                if (flourTortilla) ingredients.Add("Chicken Breast");
                if (romaineLettuce) ingredients.Add("Romaine Lettuce");
                if (ceasarDressing) ingredients.Add("Ceasar Dressing");
                if (parmesanCheese) ingredients.Add("Parmesan Cheese");
                              
                return ingredients;
            }
        }
        /// this is used to hold the item
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// this is used to hold the item
        public void HoldDressing()
        {
            this.ceasarDressing = false;
        }
        /// this is used to hold the item
        public void HoldLettuce()
        {
            this.romaineLettuce = false;
        }
        /// this is used to hold the item
        public void holdCheese()
        {
            this.parmesanCheese = false;
        }
    }
}
