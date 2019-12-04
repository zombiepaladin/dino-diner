using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
using System.ComponentModel;
/* CreteaceousCombo.cs
 * Author: Thomas Paul
 */

namespace DinoDiner.Menu
{
    public class CretaceousCombo : INotifyPropertyChanged, IOrderItem, IMenuItem
    {

        private Entree entree;
        private Drink drink;
        private Side side;
       
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

        public Entree Entree
        {
            get { return entree; }
            protected set
            {
                entree = value;
                NotifyOfPropertyChanged("Price");
               
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");


            }
        }

 

        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Ingredients");
            }
        }

       

        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Calories");

            }

        }

        /// <summary>
        /// size field initially set to small
        /// </summary>
        private Size size = Size.Small;

        public Size Size
        {
            get { return size; }
            set {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");

            }
        }

        public double Price
        {
            get
            {
                return (Drink.Price + Side.Price + Entree.Price - .25);
            }
            
        }

        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }

        }

        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }



        }

        
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();

        }

        private CretaceousCombo() { }

    }
}
