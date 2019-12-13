using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{/// <summary>
/// THis clas is used and inherited by other classes
/// </summary>
    public abstract class Drinks : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; protected set; }

        public virtual Size Size { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        public string Description { get; }
        public string[] Special { get; }

       
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
