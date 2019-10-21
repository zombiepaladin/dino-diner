using System;
using System.Collections.Generic;
using System.Text;
/*Entree.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Framework for each entree
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
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
        /// returns a list containing the ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return new List<string>(ingredients);
            }
        }

        /// <summary>
        /// string describing each entree
        /// </summary>
        public virtual string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// string with all special requests
        /// </summary>
        public abstract string[] Special { get; }
    }
}
