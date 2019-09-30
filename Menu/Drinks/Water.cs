using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drinks
    {
        public bool Lemon = false;
        public bool Ice = true;
        public Water()
        {

            this.Calories = 0;
            this.Ingredients = new List<string>() { "Water" };
            this.Price = 0.10;
            

        }




        public Size size;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {

                size = value;



                Price = .10;
                this.Calories = 0;



            }

        }

        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");


        }
        public new void HoldIce()
        {
            Ice = false;
            


        }
    }
}
