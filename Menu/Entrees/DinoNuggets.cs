﻿using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private bool nuggets = true;


        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget" };
                for(int i = 0; i < 5; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }

                return ingredients;
            }
        }


        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
        }

        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            
        }




    }
}
