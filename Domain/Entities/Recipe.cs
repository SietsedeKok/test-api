using System.Collections.Generic;

namespace Domain.Entities;

public class Recipe
{
    public int RecipeId { get; set; }
    public string Name { get; set; }
    
    public ICollection<Ingredient> Ingredients { get; set; }
}