using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// THis is the JurrasicJava that inherits Drinks
    /// </summary>
    public class JurassicJava : Drinks
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
                special.Add("Leave Room For Cream");
                special.Add("Add Ice");
                

                return special.ToArray();
            }
        }


        public override double Price
        {
            get
            {
                if (size == Size.Large) return 1.49;
                if (size == Size.Medium) return .99;
                return .59;
            }
        }

        public override uint Calories
        {
            get
            {
                if (size == Size.Large) return 8;
                if (size == Size.Medium) return 4;
                return 2;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                
                List<string> ingredients = new List<string>();

                ingredients.Add("Water");
                ingredients.Add("Coffee");
                


                return ingredients;
            }


        }

        /// <summary>
        /// THis is to leave room for cream which is false by Def.
        /// </summary>
        public bool RoomForCream = false;
        /// <summary>
        /// This is for Decaf Coffee which is set to fale by def
        /// </summary>
        public bool Decaf = false;

        /// <summary>
        /// THis is for ice and is by def set to false
        /// </summary>
        public bool Ice = false;

        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            if (size == Size.Large && Decaf == true)
            {
                return "Large Decaf Jurassic Java";
            }
            if (size == Size.Medium && Decaf == true)
            {
                return "Medium Decaf Jurassic Java";
            }
            if (size == Size.Small && Decaf == true)
            {
                return "Small Decaf Jurassic Java";
            }
            if (size == Size.Large)
            {
                return "Large Jurassic Java";
            }
            if (size == Size.Medium)
            {
                return "Medium Jurassic Java";
            }
           


            return "Small Jurassic Java";


        }

        /// <summary>
        /// The constructor for JurrasicJava that sets Cal., Ing., and price
        /// </summary>
        public JurassicJava()
        {

           
            ingredients = new List<string>() { "Water", "Coffee" };
           
           

        }



        /// <summary>
        /// This is of type Size and is used to acces Size class
        /// </summary>
        public Size size;

        /// <summary>
        /// Getter and seter that sets price and calories based on size
        /// </summary>
        public  override Size Size
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
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        // ToString() = "hello";
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        // ToString("Small");
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = 59;
                        Calories = 2;
                        break;
                }
            }



        }
        /// <summary>
        /// This makes it where there is room for cream in the coffe
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");

        }
        /// <summary>
        /// THis makes it cheap "ice" coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }


    }
}
