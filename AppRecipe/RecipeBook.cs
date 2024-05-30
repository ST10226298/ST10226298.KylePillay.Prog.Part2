using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRecipe
{
    
        class RecipeBook
        {
            public List<Recipe> Recipes { get; set; } = new List<Recipe>();

            public void AddRecipe(Recipe recipe)
            {
                Recipes.Add(recipe);
            }

            public void DisplayAllRecipes()
            {
                var sortedRecipes = Recipes.OrderBy(r => r.Name).ToList();
                foreach (var recipe in sortedRecipes)
                {
                    Console.WriteLine(recipe.Name);
                }
            }

            public Recipe GetRecipeByName(string name)
            {
                return Recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
