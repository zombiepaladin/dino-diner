using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{/// <summary>
/// THis clas is used and inherited by other classes
/// </summary>
    public abstract class Drinks
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Holds the ice
        /// </summary>
        /// <returns></returns>
        public virtual bool HoldIce()
        {
            
            return false;
        }


    }
}
