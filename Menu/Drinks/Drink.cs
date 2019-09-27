using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{



    /// <summary>
    /// Framework for each side
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Represents each side
        /// </summary>
        protected List<string> ingredients = new List<string>();
        
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients for each side
        /// </summary>
        public List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Represents if ice exists
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Leaves ice out
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }



    }
}  