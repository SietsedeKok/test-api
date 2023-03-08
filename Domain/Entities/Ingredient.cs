namespace Domain.Entities;

public class Ingredient
{
    public int IngredientId { get; set; }
    public string Name { get; set; }
    
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}