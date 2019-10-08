using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;


namespace DinoDiner.Menu
{
    public class Menu
    {
        private List<Drinks.Drink> listD = new List<Drinks.Drink>();
        private Drinks.JurrasicJava j = new Drinks.JurrasicJava();
        private Drinks.Tyrannotea t = new Drinks.Tyrannotea();
        private Drinks.Water w = new Drinks.Water();
        private Drinks.Sodasaurus s = new Drinks.Sodasaurus();

        public List<Drinks.Drink> AvailableDrinks
        {
            get
            {
                listD.Add(j);
                listD.Add(t);
                listD.Add(w);
                listD.Add(s);
                return listD;
            }


        }
        private List<Entrees.Entree> listEnt = new List<Entrees.Entree>();
        private Entrees.Brontowurst b = new Entrees.Brontowurst();
        private Entrees.DinoNuggets d = new Entrees.DinoNuggets();
        private Entrees.PrehistoricPBJ pbj = new Entrees.PrehistoricPBJ();
        private Entrees.TRexKingBurger tRex = new Entrees.TRexKingBurger();
        private Entrees.VelociWrap vWrap = new Entrees.VelociWrap();
        private Entrees.PterodactylWings pWings = new Entrees.PterodactylWings();
        private Entrees.SteakosaurusBurger sBurg = new Entrees.SteakosaurusBurger();
        public List<Entrees.Entree> AvailableEntrees
        {
            get
            {
                listEnt.Add(b);
                listEnt.Add(d);
                listEnt.Add(pbj);
                listEnt.Add(tRex);
                listEnt.Add(pWings);
                listEnt.Add(sBurg);
                listEnt.Add(vWrap);
                return listEnt;
            }


        }

        private List<Sides.Side> listSides = new List<Sides.Side>();
        private Sides.Fryceritops fry = new Sides.Fryceritops();
        private Sides.MezzorellaSticks mezz = new Sides.MezzorellaSticks();
        private Sides.Triceritots tot = new Sides.Triceritots();
        private Sides.MeteorMacAndCheese mac = new Sides.MeteorMacAndCheese();
        public List<Sides.Side> AvailableSides
        {
            get
            {
                listSides.Add(fry);
                listSides.Add(mezz);
                listSides.Add(tot);
                listSides.Add(mac);

                return listSides;
            }


        }

        private List<IMenuItem> list = new List<IMenuItem>();
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                list.Add(fry);
                list.Add(mezz);
                list.Add(tot);
                list.Add(mac);
                list.Add(b);
                list.Add(d);
                list.Add(pbj);
                list.Add(tRex);
                list.Add(sBurg);
                list.Add(vWrap);
                list.Add(j);
                list.Add(t);
                list.Add(w);
                list.Add(s);
                foreach(CretaceousCombo c in AvailableCombos)
                {
                    list.Add(c);
                }

                return list;
            }


        }

        public List<CretaceousCombo> combo = new List<CretaceousCombo>();

        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                foreach(Entrees.Entree e in AvailableEntrees)
                {
                    combo.Add(new CretaceousCombo(e));
                }
                

                return combo;
            }


        }

        

        public override string ToString()
        {
            StringBuilder fullMenu = new StringBuilder();
            foreach(IMenuItem menuItem in AvailableMenuItems)
            {
                fullMenu.Append(menuItem.ToString());
                fullMenu.Append("\n");
            }
            return fullMenu.ToString();
        }




    }
}
