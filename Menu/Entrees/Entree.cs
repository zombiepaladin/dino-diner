using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
   
        public abstract class Entree : IMenuItem , IOrderItem
    {
        

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get;  }

            /// <summary>
            /// Gets and sets the calories
            /// </summary>
            public virtual uint Calories { get;  }

            /// <summary>
            /// Gets the ingredients list
            /// </summary>
            public abstract List<string> Ingredients { get;}
            public  string[] Special { get; }
        
            public   string Description { get; }
             


    }
}
