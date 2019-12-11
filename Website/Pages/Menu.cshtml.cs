using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website
{
    public class MenuModel : PageModel
    {
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public IEnumerable<string> cesd { get; set; } = new List<string>();
        [BindProperty]
        public List<string> cats { get; set; } = new List<string>();

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        public IEnumerable<IOrderItem> sr = null;

        public PrehistoricPBJ pbj = new PrehistoricPBJ();
 
        public Brontowurst brt = new Brontowurst();

        public DinoNuggets dnn = new DinoNuggets();

        public PterodactylWings ptw = new PterodactylWings();

        public SteakosaurusBurger stb = new SteakosaurusBurger();
 
        public TRexKingBurger trb = new TRexKingBurger();

        public VelociWrap vlw = new VelociWrap();
 
        public CretaceousCombo brw = new CretaceousCombo(new Brontowurst());
   
        public CretaceousCombo dinoNugs = new CretaceousCombo(new DinoNuggets());

        public CretaceousCombo phPJ = new CretaceousCombo(new PrehistoricPBJ());
 
        public CretaceousCombo ptWings = new CretaceousCombo(new PterodactylWings());

        public CretaceousCombo stBurger = new CretaceousCombo(new SteakosaurusBurger());

        public CretaceousCombo trBurger = new CretaceousCombo(new TRexKingBurger());

        public CretaceousCombo vlWrap = new CretaceousCombo(new VelociWrap());

        public Fryceritops frt = new Fryceritops();
        
        public MeteorMacAndCheese mmm = new MeteorMacAndCheese();
        
        public MezzorellaSticks mzs = new MezzorellaSticks();

        public Triceritots tts = new Triceritots();

        public JurassicJava jrja = new JurassicJava();
        

        public Sodasaurus sdr = new Sodasaurus();
 
        public Tyrannotea trt = new Tyrannotea();

       

        public IEnumerable<CretaceousCombo> allCombos = new List<CretaceousCombo>() {new CretaceousCombo(new Brontowurst()), new CretaceousCombo(new DinoNuggets()),new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new PterodactylWings()),new CretaceousCombo(new SteakosaurusBurger()), new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())};


        public IEnumerable<Entree> allEntree = new List<Entree>() {new PrehistoricPBJ(), new Brontowurst(),
            new DinoNuggets(), new PterodactylWings(),new SteakosaurusBurger(), new TRexKingBurger(), new VelociWrap() };

        public IEnumerable<Side> allSide = new List<Side>() {
              new Fryceritops(), new MeteorMacAndCheese(), new MezzorellaSticks(), new Triceritots(), };

               
        public IEnumerable<Drinks> allDrinks = new List<Drinks>() {
              new JurassicJava(), new Sodasaurus(), new Tyrannotea(), new Water() };

        public IEnumerable<string> titles = new List<string>() { "Combos", "Entree", "Sides", "Drinks" };
             

        public void OnGet()
        {
            
          
           


        }


        public void OnPost()
        {

            if (cesd != null)
            {

                cesd = cesd.Where(menu => menu.Contains(menu, StringComparison.OrdinalIgnoreCase));
            }
           
            if (maxPrice != null)
            {
                allCombos = allCombos.Where(menu => menu.Price != null && menu.Price <= maxPrice);
                allEntree = allEntree.Where(menu => menu.Price != null && menu.Price <= maxPrice);
                allSide = allSide.Where(menu => menu.Price != null && menu.Price <= maxPrice);
                allDrinks = allDrinks.Where(menu => menu.Price != null && menu.Price <= maxPrice);
            }
            if (minPrice != null)
            {
                allCombos = allCombos.Where(menu => menu.Price != null && menu.Price >= minPrice);
                allEntree = allEntree.Where(menu => menu.Price != null && menu.Price >= minPrice);
                allSide = allSide.Where(menu => menu.Price != null && menu.Price >= minPrice);
                allDrinks = allDrinks.Where(menu => menu.Price != null && menu.Price >= minPrice);
            }
            if (cats.Count() != 0)
            {
                
                allEntree = allEntree.Where(menu => cats.Contains(menu.Ingredients,StringComparison.OrdinalIgnoreCase));
            }


        }

    }
}
