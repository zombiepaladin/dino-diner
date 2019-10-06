using System;
using System.Collections.Generic;
using System.Text;




namespace DinoDiner.Menu.Drinks
{

    /// <summary>
    /// Class for SodaSauris that inherits Drinks
    /// </summary>
    public class SodaSaurus : Drinks
    {

        /// <summary>
        /// Shows that Ice is in by default
        /// </summary>
        public bool Ice = true;

        /// <summary>
        /// Constructor for SodaSaurus that sets def Cal.,Ing., and Price
        /// </summary>
        public SodaSaurus()
        {
            
            this.Calories = 112;
            this.Ingredients = new List<string>() {"Water","Natural Flavors","Cane Sugar" };
            this.Price = 1.50;
            
            
        }

        /// <summary>
        /// Private varriable that accesses SodasaurusFlavor to set the Default flavor
        /// </summary>
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;

        /// <summary>
        /// The getter and setter for SodasaurusFlavor to make it pick a flavor or get the flavor that is set
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }

        }
        

        /// <summary>
        /// Variable of type Size that is used to acces Size class
        /// </summary>
        public Size size;
        /// <summary>
        /// The getter and setter that sets Price and Cal. based on size
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
                    Price = 1.50;
                    this.Calories = 112;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    this.Calories = 156;
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                    this.Calories = 208;
                }
                
            }

        }


        /// <summary>
        /// Hold the ice in the drink
        /// </summary>
        /// <returns>Returns false to show there is no ice</returns>
        public override bool HoldIce()
        {
            Ice = false;
            return false;
        }




    }
}
