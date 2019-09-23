using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Framework for each entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Represents ingredients for each entree
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
        /// Gets the ingredients for each entree
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }



        }
}
