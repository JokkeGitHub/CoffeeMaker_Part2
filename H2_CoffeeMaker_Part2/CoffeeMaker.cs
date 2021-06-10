using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_CoffeeMaker_Part2
{
    public class CoffeeMaker : Machine, ICoffee, ITea
    {
        // This class is responsible for the object class "CoffeMaker"

        private string _ingredient;
        private int _waterContainerInMl;
        private int _ingredientContainerInGram;
        private int _pitcherContainereInMl;
        private bool _filterInContainer;

        public string Ingredient
        {
            get
            {
                return this._ingredient;
            }
            set
            {
                this._ingredient = value;
            }
        }

        public int WaterContainerInMl
        {
            get
            {
                return this._waterContainerInMl;
            }
            set
            {
                this._waterContainerInMl = value;
            }
        }

        public int IngredientContainerInGram
        {
            get
            {
                return this._ingredientContainerInGram;
            }
            set
            {
                this._ingredientContainerInGram = value;
            }
        }

        public int PitcherContainerInMl
        {
            get
            {
                return this._pitcherContainereInMl;
            }
            set
            {
                this._pitcherContainereInMl = value;
            }
        }

        public bool FilterInContainer
        {
            get
            {
                return this._filterInContainer;
            }
            set
            {
                this._filterInContainer = value;
            }
        }

        public CoffeeMaker(string ingredient, int waterContainerInMl, int ingredientContainerInGram, int pitcherContainerInMl, bool filterInContainer, bool hasElectricity, bool turnedOn) : base(hasElectricity, turnedOn)
        {
            Ingredient = ingredient;
            WaterContainerInMl = waterContainerInMl;
            IngredientContainerInGram = ingredientContainerInGram;
            PitcherContainerInMl = pitcherContainerInMl;
            FilterInContainer = filterInContainer;
        }

        public void AddWater()
        {
            WaterContainerInMl += 200;
            Console.WriteLine("Added water for 1 cup. (200ml)");
        }

        public void AddIngredient()
        {
            if (FilterInContainer == true)
            {
                IngredientContainerInGram += 10;
                Console.WriteLine($"Added {Ingredient} for 1 cup. (10 grams)");
            }
            else
            {
                Console.WriteLine($"No filter in the ingredient container. {Ingredient} went directly through and into the pitcher.");
            }
        }

        public void BrewHotBeverage()
        {
            if (TurnedOn == true)
            {
                Console.WriteLine($"{Ingredient} is brewing");
                
                for (int i = WaterContainerInMl; i > 0; i -= 200)
                {
                    WaterContainerInMl -= 200;
                    IngredientContainerInGram -= 10;
                    PitcherContainerInMl += 200;

                    Console.WriteLine($"{Ingredient} for 1 cup is added to pitcher.");                    
                }

                Console.WriteLine($"{Ingredient} is done brewing.");
            }
        }

        public void AddFilter()
        {
            FilterInContainer = true;
            Console.WriteLine("Added filter to the ingrdient container.");
        }

        void ICoffee.AddCoffeeAsIngredient()
        {
            Ingredient = "Coffee";
        }

        void ITea.AddTeaAsIngredient()
        {
            Ingredient = "Tea";
        }
    }
}
