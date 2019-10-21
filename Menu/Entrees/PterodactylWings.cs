using System.Collections.Generic;
using System.ComponentModel;
using DinoDiner.Menu.Entrees;
namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree, INotifyPropertyChanged, IOrderItem
    {
     
  

        

        /// <summary>
        /// Initial price and calories of wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }

        /// <summary>
        /// Returns a string[] of special requests
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
