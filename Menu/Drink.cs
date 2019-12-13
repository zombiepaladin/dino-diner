using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/*Author: Thomas Paul
 * Drink.cs
 */
namespace DinoDiner.Menu
{



    /// <summary>
    /// Framework for each side
    /// </summary>
    public abstract class Drink : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Represents each side
        /// </summary>
        protected List<string> ingredients = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public abstract string Type { get; }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients for each side
        /// </summary>
        public virtual List<string> Ingredients { get { return new List<string>(ingredients); } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Represents if ice exists
        /// </summary>
        public bool Ice  = true;

        /// <summary>
        /// Omits ice
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyIfPropertyChanged("Special");
        }

        /// <summary>
        /// returns a string describing each drink
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Returns string of special notes for all drinks
        /// </summary>
        public abstract string[] Special { get; }


    }
}  