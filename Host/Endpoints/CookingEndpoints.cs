namespace Host.Endpoints;

public static class CookingEndpoints
{
    public static void AddCookingEndpoints(IEndpointRouteBuilder app)
    {
        // Cooking
        app.MapGet("/cooking", 
            () => "Cooking Dashboard!");
        
        // Recipes
        app.MapGet("/cooking/recipes", 
            () => "Recipes!");
    
        app.MapGet("/cooking/recipes/{recipeId:int}", 
            (int recipeId) => $"Recipe with ID: {recipeId}!");
    
        app.MapGet("/cooking/recipes/{recipeId:int}/ingredients", 
            (int recipeId) => $"Ingredients of Recipe with ID: {recipeId}!");
    
        app.MapGet("/cooking/recipes/{recipeId:int}/ingredients/{ingredientId:int}", 
            (int recipeId, int ingredientId) => $"Ingredient with ID: {ingredientId} of Recipe with ID: {recipeId}!");

        // Ingredients
        app.MapGet("/cooking/ingredients", 
            () => "Ingredients!");
    }
}