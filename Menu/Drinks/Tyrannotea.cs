using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{

    /// <summary>
    /// THis is the class for the Tea and inherits from Drinks
    /// </summary>
    public class Tyrannotea : Drinks
    {


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
               if(lemon) special.Add("Add Lemon");
               if(ice) special.Add("Add Ice");
               if(Sweet) special.Add("Add Cane Sugar");
               if(!Sweet) special.Add("Remove Cane Sugar");


                return special.ToArray();
            }
        }


        public override double Price
        {
            get
            {
                if (size == Size.Large) return 1.99;
                if (size == Size.Medium) return 1.49;
                return .99;
            }
        }

        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    if (size == Size.Large) return 32*2;
                    if (size == Size.Medium) return 16*2;
                    return 8*2;

                }
                else
                {
                    if (size == Size.Large) return 32;
                    if (size == Size.Medium) return 16;
                    return 8;

                }
                
            }
        }

        public override List<string> Ingredients
        {
            get
            {

                List<string> ingredients = new List<string>();
                
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if(lemon)ingredients.Add("Lemon");
                if(Sweet)ingredients.Add("Cane Sugar");
                


                return ingredients;
            }


        }



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

            
            ingredients = new List<string>() { "Water", "Tea" };
            
           


        }

        /// <summary>
        /// This variable is default to make tea non sweet
        /// </summary>
        public bool Sweet = false;
        /// <summary>
        /// This indicates there is no lemon in tea by default
        /// </summary>
        public bool lemon = false;
        /// <summary>
        /// This indicates that ice is default true in tea
        /// </summary>
        public bool ice = true;

        /// <summary>
        /// This variable is of type Size and is used to access class size
        /// </summary>
        public Size size;

        /// <summary>
        /// Getter and setter for Size and sets the calories and price for each size
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
                        Price = 1.99;
                        Calories = 32;
                        break;
                    case Size.Medium:
                        // ToString() = "hello";
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Small:
                        // ToString("Small");
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = 0.99;
                        Calories = 8;
                        break;
                }
            }



        }


        /// <summary>
        /// This adds Lemon in the tea
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            ingredients.Add("Lemon");

            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");


        }


        /// <summary>
        /// This makes The tea sweet
        /// </summary>
        public void AddSweet()
        {
            Sweet = true;
            Ingredients.Add("Cane Sugar");
            Calories = this.Calories * 2;

            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");


        }

        //This makes the tea Back to normal
        public void RemoveSweet()
        {
            Sweet = false;
            Ingredients.Add("Cane Sugar");
            this.Calories = this.Calories;

            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");


        }
        /// <summary>
        /// This holds the ice in the tea
        /// </summary>
        /// <returns>false to show that the ice is held</returns>
        public override bool HoldIce()
        {
             ice = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            return false;

            
        }

    }
}
