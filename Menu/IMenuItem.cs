﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public  interface IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        uint Calories { get; }

  

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
          
        List<string> Ingredients { get; }

        
    }
}
