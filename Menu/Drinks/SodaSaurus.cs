using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;



namespace DinoDiner.Menu
{




    /// <summary>
    /// Class for SodaSauris that inherits Drinks
    /// </summary>
    public class Sodasaurus : Drinks 
    {


        private List<string> ingredients;


       

        /// <summary>
        /// PropertyChanged event handeler; notifys of changes to the Price,Description,and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        //Helper Function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       

        public override double Price
        {
            get
            {
                if (size == Size.Large) return 2.50;
                if (size == Size.Medium) return 2.00;
                return 1.50;
            }
        }

        public override uint Calories
        {
            get
            {
                if (size == Size.Large) return 208;
                if (size == Size.Medium) return 156;
                return 112;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                
                List<string> ingredients = new List<string>();

                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");



                return ingredients;
            }


        }


        /// <summary>
        /// Shows that Ice is in by default
        /// </summary>
        public bool Ice = true;
        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            if (size == Size.Large)
            {
                return "Large " + flavor + " Sodasaurus";
            }
            if (size == Size.Medium)
            {
                return "Medium "+ flavor + " Sodasaurus";
            }

            return "Small " + flavor + " Sodasaurus";


        }


        /// <summary>
        /// Gets the description of this oder item
        /// </summary>
        public string Description
        {

            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special intructions for this order item
        /// </summary>

        public string[] Special
        {

            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
                

                

            }

        }


       
        /// <summary>
        /// Constructor for SodaSaurus that sets def Cal.,Ing., and Price
        /// </summary>
        public Sodasaurus()
        {
            
            this.Calories = 112;
            ingredients = new List<string>() {"Water","Natural Flavors","Cane Sugar" };
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
        public override Size Size
        {

            set
            {

                size = value;

                switch (size)
                {

                    case Size.Large:
                        // ToString("Large");
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Size");
                        base.Size = value;
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        // ToString() = "hello";
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        // ToString("Small");
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = 1.50;
                        Calories = 112;
                        break;
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
