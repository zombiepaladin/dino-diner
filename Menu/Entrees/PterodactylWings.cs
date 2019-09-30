﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
namespace Menu.Entrees
{
    public class PterodactylWings : Entree
    {
     
  

        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                
                return ingredients;
            }
        }

        /// <summary>
        /// Initial price and calories of wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        
    }
}
