using System.Collections.Generic;
using System.ComponentModel;
using DinoDiner.Menu.Entrees;
/*DinoNuggets.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        
      
        /// <summary>
        /// Represents the number of nuggets
        /// </summary>
        public int count = 0;


        


        

        /// <summary>
        /// Initial price and calories of dino nugget
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
            for (int i = 0; i < (6); i++)
            {
                ingredients.Add("Chicken Nugget");
            }
            
        }

        /// <summary>
        /// Nugget is added
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            ingredients.Add("Chicken Nugget");
            NotifyIfPropertyChanged("Special");
            NotifyIfPropertyChanged("Price");
            NotifyIfPropertyChanged("Description");
            NotifyIfPropertyChanged("Ingredients");
            count++;
        }
        public override string ToString()
        {
            return ("Dino-Nuggets");
        }

        /// <summary>
        /// Returns a string[] that contains all special items
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(count.ToString() + " " + "Extra Nuggets");
                return special.ToArray();
            }
        }
    }
    }
