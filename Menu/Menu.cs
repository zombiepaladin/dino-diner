using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// List for string to IMenu
        /// </summary>
        public List<string> Ingredients;


        /// <summary>
        /// List to avalible menu items
        /// </summary>
       List<string> AvailableMenuItems 
        {
            get
            {
                return AvailableMenuItems;
            }
                 


        }

        /// <summary>
        /// Menu sets up instances of all iteam to put in AvailableMenuItems
        /// </summary>
        public Menu()
        {
            
            Brontowurst b = new Brontowurst();
            AvailableMenuItems.Add(b.ToString());
            DinoNuggets d = new DinoNuggets();
            AvailableMenuItems.Add(d.ToString());
            PrehistoricPBJ pr = new PrehistoricPBJ();
            AvailableMenuItems.Add(pr.ToString());
            PterodactylWings pt = new PterodactylWings();
            AvailableMenuItems.Add(pt.ToString());
            SteakosaurusBurger st = new SteakosaurusBurger();
            AvailableMenuItems.Add(st.ToString());
            TRexKingBurger tr = new TRexKingBurger();
            AvailableMenuItems.Add(tr.ToString());
            VelociWrap ve = new VelociWrap();
            AvailableMenuItems.Add(ve.ToString());
            Fryceritops fr = new Fryceritops();
            AvailableMenuItems.Add(fr.ToString());
            Triceritots tri = new Triceritots();
            AvailableMenuItems.Add(tri.ToString());
            MeteorMacAndCheese mc = new MeteorMacAndCheese();
            AvailableMenuItems.Add(mc.ToString());
            MezzorellaSticks me = new MezzorellaSticks();
            AvailableMenuItems.Add(me.ToString());
            Tyrannotea ty = new Tyrannotea();
            AvailableMenuItems.Add(ty.ToString());
            Sodasaurus so = new Sodasaurus();
            AvailableMenuItems.Add(so.ToString());
            JurassicJava jr = new JurassicJava();
            AvailableMenuItems.Add(jr.ToString());
            Water wa = new Water();
            AvailableMenuItems.Add(wa.ToString());
            Ingredients = AvailableMenuItems;


        }

    }
}
        



       
    



