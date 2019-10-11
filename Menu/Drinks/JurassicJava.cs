﻿using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// THis is the JurrasicJava that inherits Drinks
    /// </summary>
    public class JurassicJava : Drinks
    {
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

            this.Calories = 2;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
            this.Price = .59;
           

        }



        /// <summary>
        /// This is of type Size and is used to acces Size class
        /// </summary>
        public Size size;

        /// <summary>
        /// Getter and seter that sets price and calories based on size
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
                    Price = .59;
                    this.Calories = 2;
                }
                else if (size == Size.Medium)
                {
                    Price = .99;
                    this.Calories = 4;
                }
                else if (size == Size.Large)
                {
                    Price = 1.49;
                    this.Calories = 8;
                }

            }

        }
        /// <summary>
        /// This makes it where there is room for cream in the coffe
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;

        }
        /// <summary>
        /// THis makes it cheap "ice" coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }


    }
}
