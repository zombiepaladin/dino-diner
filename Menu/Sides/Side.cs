﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{

    /// <summary>
    /// Enum to defign size into three Strings
    /// </summary>
    

    public  class Side : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public  uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public  virtual Size Size {  get; set; }

    }
}
