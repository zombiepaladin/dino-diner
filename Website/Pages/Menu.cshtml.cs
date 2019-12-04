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
        public PrehistoricPBJ pbj = new PrehistoricPBJ();
        public string pbjDiscription;
        public List<string> pbjIngredients;
        public uint pbjCalories;
        public double pbjPrice;

        public Brontowurst brt = new Brontowurst();
        public string brtDiscription;
        public List<string> brtIngredients;
        public uint brtCalories;
        public double brtPrice;

        public DinoNuggets dnn = new DinoNuggets();
        public string dnnDiscription;
        public List<string> dnnIngredients;
        public uint dnnCalories;
        public double dnnPrice;

        public PterodactylWings ptw = new PterodactylWings();
        public string ptwDiscription;
        public List<string> ptwIngredients;
        public uint ptwCalories;
        public double ptwPrice;

        public SteakosaurusBurger stb = new SteakosaurusBurger();
        public string stbDiscription;
        public List<string> stbIngredients;
        public uint stbCalories;
        public double stbPrice;

        public TRexKingBurger trb = new TRexKingBurger();
        public string trbDiscription;
        public List<string> trbIngredients;
        public uint trbCalories;
        public double trbPrice;

        public VelociWrap vlw = new VelociWrap();
        public string vlwDiscription;
        public List<string> vlwIngredients;
        public uint vlwCalories;
        public double vlwPrice;


        /// <summary>
        /// Combos
        /// </summary>
        public CretaceousCombo brw = new CretaceousCombo(new Brontowurst());
        public string discriptionsBrw;
        public List<string> comboInBrw;
        public Side combosideBrw;
        public Drinks combodrinksBrw;
        public uint comboCaloriesBrw;
        public double comboPricesBrw;

        public CretaceousCombo dinoNugs = new CretaceousCombo(new DinoNuggets());
        public string discriptionsDinoNugs;
        public List<string> comboInDinoNugs;
        public Side combosideDinoNugs;
        public Drinks combodrinksDinoNugs;
        public uint comboCaloriesdinoNugs;
        public double comboPricesdinoNugs;


        public CretaceousCombo phPJ = new CretaceousCombo(new PrehistoricPBJ());
        public string discriptionsphPJ;
        public List<string> comboInphPJ;
        public Side combosidephPJ;
        public Drinks combodrinksphPJ;
        public uint comboCaloriesphPJ;
        public double comboPricesphPJ;


        public CretaceousCombo ptWings = new CretaceousCombo(new PterodactylWings());
        public string discriptionsptWings;
        public List<string> comboInptWings;
        public Side combosideptWings;
        public Drinks combodrinksptWings;
        public uint comboCaloriesptWings;
        public double comboPricesptWings;


        public CretaceousCombo stBurger = new CretaceousCombo(new SteakosaurusBurger());
        public string discriptionsstBurger;
        public List<string> comboInstBurger;
        public Side combosidestBurger;
        public Drinks combodrinksstBurger;
        public uint comboCaloriesstBurger;
        public double comboPricesstBurger;


        public CretaceousCombo trBurger = new CretaceousCombo(new TRexKingBurger());
        public string discriptionstrBurger;
        public List<string> comboIntrBurger;
        public Side combosidetrBurger;
        public Drinks combodrinkstrBurger;
        public uint comboCaloriestrBurger;
        public double comboPricestrBurger;


        public CretaceousCombo vlWrap = new CretaceousCombo(new VelociWrap());
        public string discriptionsvlWrap;
        public List<string> comboInvlWrap;
        public Side combosidevlWrap;
        public Drinks combodrinksvlWrap;
        public uint comboCaloriesvlWrap;
        public double comboPricesvlWrap;


        /// <summary>
        /// Sides
        /// </summary>
        public Fryceritops frt = new Fryceritops();
        public string frtDescription;
        public double frtPrice;
        public uint frtCalories;
        public List<string> frtIngredience;

        public MeteorMacAndCheese mmm = new MeteorMacAndCheese();
        public string mmmDescription;
        public double mmmPrice;
        public uint mmmCalories;
        public List<string> mmmIngredience;

        public MezzorellaSticks mzs = new MezzorellaSticks();
        public string mzsDescription;
        public double mzsPrice;
        public uint mzsCalories;
        public List<string> mzsIngredience;



        public Triceritots tts = new Triceritots();
        public string ttsDescription;
        public double ttsPrice;
        public uint ttsCalories;
        public List<string> ttsIngredience;






        /// <summary>
        /// Drinks
        /// </summary>
        public JurassicJava jrja = new JurassicJava();
        public string jrjaDescription;
        public double jrjaPrice;
        public uint jrjaCalories;
        public List<string> jrjaIngredience;



        public Sodasaurus sdr = new Sodasaurus();
        public string sdrDescription;
        public double sdrPrice;
        public uint sdrCalories;
        public List<string> sdrIngredience;



        public Tyrannotea trt = new Tyrannotea();
        public string trtDescription;
        public double trtPrice;
        public uint trtCalories;
        public List<string> trtIngredience;




        public void OnGet()
        {
            pbjDiscription = pbj.Discription;
            pbjIngredients = pbj.Ingredients;
            pbjPrice = pbj.Price;
            pbjCalories = pbj.Calories;

            brtDiscription = brt.Discription;
            brtIngredients = brt.Ingredients;
            brtPrice = brt.Price;
            brtCalories = brt.Calories;

            dnnDiscription = dnn.Description;
            dnnIngredients = dnn.Ingredients;
            dnnPrice = dnn.Price;
            dnnCalories = dnn.Calories;

            ptwDiscription = ptw.Description;
            ptwIngredients = ptw.Ingredients;
            ptwPrice = ptw.Price;
            ptwCalories = ptw.Calories;

            stbDiscription = stb.Description;
            stbIngredients = stb.Ingredients;
            stbPrice = stb.Price;
            stbCalories = stb.Calories;

            trbDiscription = trb.Description;
            trbIngredients = trb.Ingredients;
            trbPrice = trb.Price;
            trbCalories = trb.Calories;

            vlwDiscription = vlw.Description;
            vlwIngredients = vlw.Ingredients;
            vlwPrice = vlw.Price;
            vlwCalories = vlw.Calories;





            discriptionsBrw = brw.Description;
            comboInBrw = brw.Ingredients;
            combosideBrw = brw.Side;
            combodrinksBrw = brw.Drink;
            comboCaloriesBrw = brw.Calories;
            comboPricesBrw = brw.Price;


            discriptionsDinoNugs = dinoNugs.Description;
            comboInDinoNugs = dinoNugs.Ingredients;
            combosideDinoNugs = dinoNugs.Side;
            combodrinksDinoNugs = dinoNugs.Drink;
            comboCaloriesdinoNugs = dinoNugs.Calories;
            comboPricesdinoNugs = dinoNugs.Price;



            discriptionsphPJ = phPJ.Description;
            comboInphPJ = phPJ.Ingredients;
            combosidephPJ = phPJ.Side;
            combodrinksphPJ = phPJ.Drink;
            comboCaloriesphPJ = phPJ.Calories;
            comboPricesphPJ = phPJ.Price;



            discriptionsptWings = ptWings.Description;
            comboInptWings = ptWings.Ingredients;
            combosideptWings = ptWings.Side;
            combodrinksptWings = ptWings.Drink;
            comboCaloriesptWings = ptWings.Calories;
            comboPricesptWings = ptWings.Price;


            discriptionsstBurger = stBurger.Description;
            comboInstBurger = stBurger.Ingredients;
            combosidestBurger = stBurger.Side;
            combodrinksstBurger = stBurger.Drink;
            comboCaloriesstBurger = stBurger.Calories;
            comboPricesstBurger = stBurger.Price;



            discriptionstrBurger = trBurger.Description;
            comboIntrBurger = trBurger.Ingredients;
            combosidetrBurger = trBurger.Side;
            combodrinkstrBurger = trBurger.Drink;
            comboCaloriestrBurger = trBurger.Calories;
            comboPricestrBurger = trBurger.Price;



            discriptionsvlWrap = vlWrap.Description;
            comboInvlWrap = vlWrap.Ingredients;
            combosidevlWrap = vlWrap.Side;
            combodrinksvlWrap = vlWrap.Drink;
            comboCaloriesvlWrap = vlWrap.Calories;
            comboPricesvlWrap = vlWrap.Price;




        
        frtDescription =frt.Description;
        frtPrice =frt.Price;
        frtCalories =frt.Calories;
        frtIngredience = frt.Ingredients;

        
        mmmDescription = mmm.Description;
        mmmPrice = mmm.Price;
        mmmCalories = mmm.Calories;
        mmmIngredience = mmm.Ingredients;

        
        mzsDescription = mzs.Description;
        mzsPrice = mzs.Price;
        mzsCalories = mzs.Calories;
        mzsIngredience = mzs.Ingredients;


        ttsDescription = tts.Description;
        ttsPrice = tts.Price;
        ttsCalories = tts.Calories;
        ttsIngredience = tts.Ingredients;








        jrjaDescription = jrja.Description;
            jrjaPrice = jrja.Price;
            jrjaCalories = jrja.Calories;
            jrjaIngredience = jrja.Ingredients;


            sdrDescription = sdr.Description;
            sdrPrice = sdr.Price;
            sdrCalories = sdr.Calories;
            sdrIngredience = sdr.Ingredients;

            trtDescription = trt.Description;
            trtPrice = trt.Price;
            trtCalories = trt.Calories;
            trtIngredience = trt.Ingredients;




        }
    }
}
