using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Gets or sets 
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; }

        

        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;



                }



            }
            get { return size; }

        }
        public void AddIce()
        {
            Ice = true;
        }

        
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        public JurrasicJava()
        {
            this.Price = .59;
            this.Calories = 2;
            Ice = false;
            RoomForCream = false;
            
            
        }
        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch(size)
            {
                case Size.Small:
                    item.Append("Small ");
                    if(Decaf)
                    {
                        item.Append("Decaf ");
                    }
                    break;
                case Size.Medium:
                    item.Append("Medium ");
                    if (Decaf)
                    {
                        item.Append("Decaf ");
                    }
                    break;
                case Size.Large:
                    item.Append("Large ");
                    if (Decaf)
                    {
                        item.Append("Decaf ");
                    }
                    break;
                default:
                    break;


            }
            item.Append("Jurassic Java");
            return item.ToString();
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                Ingredients.Add("Water");
                Ingredients.Add("Coffee");

                return ingredients;
            }
        }
    }
    
}

