using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
 
    /// <summary>
    /// Framework for each side
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public abstract string Type { get; }
        
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets the ingredients for each side
        /// </summary>
        public virtual List<string> Ingredients {
            get
            {
                return new List<string>(ingredients);

            }
        }

        /// <summary>
        /// Returns a description for the sides 
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Returns a string[] of special requests
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
