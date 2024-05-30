using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRecipe
{

    public class Recipe
    { public string Name { get; set; }
        public Ingredient[] Ingredients { get; set; } // declares array

        public Steps[] Steps { get; set; } // delcares array
    
    }
    public Recipe(string name, int numIngredients, int numSteps)
    {
        Ingredients = new List<Ingredient>();
        Steps = new List<Steps>();
            
            
            public void DisplayRecipe()
        {
            Console.WriteLine("Recipe Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nRecipe Steps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        public void Scale(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void Reset()
        {
        }

        public void Clear()
        {
            Ingredients.Clear();
            Steps.Clear();


        }
    }
}