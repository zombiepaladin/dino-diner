using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class DinoNuggets
    {
        

        public double Price { get; set; }
        public uint Calories { get; set; }


        public int Count = 6;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                for(int i = 0; i < Count; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            Count++;
        }
    }
    }
