using System.Collections.Generic;

namespace DinoDiner.Menu
{

    /// <summary>
    /// THis is the class for the Tea and inherits from Drinks
    /// </summary>
    public class Tyrannotea : Drinks
    {

        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            if (size == Size.Large && Sweet == true)
            {
                return "Large Sweet Tyrannotea";
            }
            if (size == Size.Medium && Sweet == true)
            {
                return "Medium Sweet Tyrannotea";
            }
            if (size == Size.Small && Sweet == true)
            {
                return "Small Sweet Tyrannotea";
            }
            if (size == Size.Large)
            {
                return "Large Tyrannotea";
            }
            if (size == Size.Medium)
            {
                return "Medium Tyrannotea";
            }



            return "Small Tyrannotea";


        }
        /// <summary>
        /// public constructor for Tyranotea that sets Cal., Ing., and price
        /// </summary>
        /// 
        public Tyrannotea()
        {

            this.Calories = 8;
            this.Ingredients = new List<string>() { "Water", "Tea" };
            this.Price = 0.99;
           


        }

        /// <summary>
        /// This variable is default to make tea non sweet
        /// </summary>
        public bool Sweet = false;
        /// <summary>
        /// This indicates there is no lemon in tea by default
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// This indicates that ice is default true in tea
        /// </summary>
        public bool Ice = true;

        /// <summary>
        /// This variable is of type Size and is used to access class size
        /// </summary>
        public Size size;

        /// <summary>
        /// Getter and setter for Size and sets the calories and price for each size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {

                size = value;

                if (size == Size.Small)
                {
                    Price = 0.99;
                    this.Calories = 8;
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49;
                    this.Calories = 16;
                }
                else if (size == Size.Large)
                {
                    Price = 1.99;
                    this.Calories = 32;
                }

            }

        }


        /// <summary>
        /// This adds Lemon in the tea
        /// </summary>
        public void AddLemon()
        {
            Ingredients.Add("Lemon");

            Lemon = true;


        }


        /// <summary>
        /// This makes The tea sweet
        /// </summary>
        public void AddSweet()
        {
            Ingredients.Add("Cane Sugar");
            this.Calories = this.Calories * 2;

            Sweet = true;


        }

        //This makes the tea Back to normal
        public void RemoveSweet()
        {
            Ingredients.Add("Cane Sugar");
            this.Calories = this.Calories;

            Sweet = false;


        }
        /// <summary>
        /// This holds the ice in the tea
        /// </summary>
        /// <returns>false to show that the ice is held</returns>
        public override bool HoldIce()
        {
             Ice = false;
            return false;

        }

    }
}
