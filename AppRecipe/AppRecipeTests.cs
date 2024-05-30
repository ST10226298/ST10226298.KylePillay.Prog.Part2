
using System.Xml.Linq;
using System;
using AppRecipe;
using System.Collections.Generic;

namespace AppRecipe
{
    internal class AppRecipeTests
    {

        public class RecipeTests
        {
            [TestMethod]
            public void TestTotalCalories()
            {
                // Arrange
                var recipe = new Recipe("Test Recipe");
                recipe.AddIngredient(new Ingredient("Sugar", 2, "tbsp", 100, "Sweets"));
                recipe.AddIngredient(new Ingredient("Butter", 1, "cup", 200, "Dairy"));

                // Act
                var totalCalories = recipe.Ingredients.Sum(i => i.Calories);

                // Assert
                Assert.AreEqual(300, totalCalories);
            }
        }
    }
   






    
}
