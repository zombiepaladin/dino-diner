using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// This class is for the DinoNuggets and is used to setup and modify it
    /// </summary>
    public class DinoNuggets : Entree , IOrderItem, INotifyPropertyChanged
    {

        private bool addNugget = false;
        private bool addMore = false;
        private bool addMoreMore = false;
        private uint cals = 59*6;
        private double price = 4.25;
        private List<string> ingredients;




        public string Description
        {

            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// PropertyChanged event handeler; notifys of changes to the Price,Description,and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        //Helper Function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets any special preperatoin instruction
        /// </summary>
        public string[] Special
        {

            get
            {
                List<string> special = new List<string>();
                 if(addNugget)special.Add("Add Chicken Nugget");
                 

                return special.ToArray();
            }
        }





        public override double Price
        {
            get
            {
                if (addMoreMore) return 5;
                if (addMore) return price +.50;
                if (addNugget) return price + .25;
                
                return 4.25;
            }
        }

        public override uint Calories
        {
            get
            {
                if (addMoreMore)
                {
                    return 531;
                }

                if (addMore)
                {
                    cals  = 472;
                    return cals;
                }
                if (addNugget)
                {
                    cals = 59 * 7;
                    return cals;
                }
                
                return cals;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                if(addNugget) ingredients.Add("Chicken Nugget");
                if (addMore) ingredients.Add("Chicken Nugget");
                return ingredients;
            }


        }



        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }


        /// <summary>
        /// Sets base price, Calories, and Ingredients for DinoNuggets
        /// </summary>
        public DinoNuggets()
        {
            
            ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" };
        }
        /// <summary>
        /// Adds an extra nugget to the meal and adds price and Calories of that one nugget 
        /// </summary>
        public void AddNugget()
        {

            if (addMore) addMoreMore = true;
            if (addNugget) addMore = true;
            addNugget = true;
            ingredients.Add( "Chicken Nugget");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");

        }




    }
}
