using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
/* Menu.cs
 * Author: Thomas Paul
 */

namespace DinoDiner.Menu
{
    public class Menu
    {
        private List<Drink> listD = new List<Drink>();
        private JurassicJava j = new JurassicJava();
        private Tyrannotea t = new Tyrannotea();
        private Water w = new Water();
        private Sodasaurus s = new Sodasaurus();

        public List<Drink> AvailableDrinks
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
        private List<Entree> listEnt = new List<Entree>();
        private Brontowurst b = new Brontowurst();
        private DinoNuggets d = new DinoNuggets();
        private PrehistoricPBJ pbj = new PrehistoricPBJ();
        private TRexKingBurger tRex = new TRexKingBurger();
        private VelociWrap vWrap = new VelociWrap();
        private PterodactylWings pWings = new PterodactylWings();
        private SteakosaurusBurger sBurg = new SteakosaurusBurger();
        public List<Entree> AvailableEntrees
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

        private List<Side> listSides = new List<Side>();
        private Fryceritops fry = new Fryceritops();
        private MezzorellaSticks mezz = new MezzorellaSticks();
        private Triceritots tot = new Triceritots();
        private MeteorMacAndCheese mac = new MeteorMacAndCheese();
        public List<Side> AvailableSides
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

                foreach (Entree e in AvailableEntrees)
                {
                    list.Add(new CretaceousCombo(e));
                }


                
                return list;
            }


        }

        public List<CretaceousCombo> combo = new List<CretaceousCombo>();

        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                foreach(Entree e in AvailableEntrees)
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

        public List<string> PossibleIngredients
        {
            get
            {
                List<string> ingr = new List<string>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    foreach (string s in item.Ingredients)
                    {
                        if (!ingr.Contains(s))
                        {
                            ingr.Add(s);
                        }
                    }
                }
                return ingr;
            }
        }


    }
}
