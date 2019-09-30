using System;
using System.Collections.Generic;
using System.Text;




namespace DinoDiner.Menu.Drinks
{
    public class TyrannoTea : Drinks
    {
        public bool Ice = true;
        public TyrannoTea()
        {
            
            this.Calories = 112;
            this.Ingredients = new List<string>() {"Water","Natural Flavors","Cane Sugar" };
            this.Price = 1.50;
            
            
        }
       

        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }

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
                    Price = 1.50;
                    this.Calories = 112;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    this.Calories = 156;
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                    this.Calories = 208;
                }
                
            }

        }

        public new void HoldIce()
        {
            Ice = false;
        }




    }
}
