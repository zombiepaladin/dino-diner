using System;
using System.Collections.Generic;
using System.Text;



namespace DinoDiner.Menu.Drinks
{
    public class SodaSaurus
    {
        
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
                if (size == Size.Small)
                {
                    Price = 1.50;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                }
            }

        }

        public double Price = 1.50;

    }
}
