using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drinks
    {

        public bool RoomForCream = false;
        public bool Decaf = false;
        public bool Ice = false;

        public JurrasicJava()
        {

            this.Calories = 2;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
            this.Price = .59;
            HoldIce();

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

                if (size == Size.Small)
                {
                    Price = .59;
                    this.Calories = 2;
                }
                else if (size == Size.Medium)
                {
                    Price = .99;
                    this.Calories = 4;
                }
                else if (size == Size.Large)
                {
                    Price = 1.49;
                    this.Calories = 8;
                }

            }

        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;

        }

        public void AddIce()
        {
            Ice = true;
        }


    }
}
