using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{

    /// <summary>
    /// Enum to defign size into three Strings
    /// </summary>
    

    public abstract class Side : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public  virtual uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get;  }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public  virtual Size Size {  get; set; }

    }
}
