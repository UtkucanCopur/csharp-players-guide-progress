(FoodType food, Ingredients ingredients, Seasoning seasoing) meal;

Console.WriteLine("Choose your meal: ");

meal.food = GetFoodType();
meal.ingredients = GetIngredients();
meal.seasoing = GetSeasoning();
DisplayMeal();




FoodType GetFoodType()
{
    Console.WriteLine("For food type: Soup, Stew, Gumbo");
    string? inputFoodType = Console.ReadLine();

    FoodType FoodType = inputFoodType?.ToLower() switch
    { 
        "soup" => FoodType.SOUP,
        "stew" => FoodType.STEW,
        "gumbo" => FoodType.GUMBO,
        _ => FoodType.INVALID
    };
    return FoodType;
}

Ingredients GetIngredients()
{
    Console.WriteLine("For ingredients: Mushrooms, Chicken, Carrots, Potatoes");
    string? inputIngredients = Console.ReadLine();

    Ingredients Ingredients = inputIngredients?.ToLower() switch
    {
        "mushrooms" => Ingredients.MUSHROOMS,
        "chicken" => Ingredients.CHICKEN,
        "carrots" => Ingredients.CARROTS,
        "potatoes" => Ingredients.POTATOES,
        _ => Ingredients.INVALID
    };

    return Ingredients;
}

Seasoning GetSeasoning()
{
    Console.WriteLine("For seasoning: Spicy, Salty, Sweet");
    string? inputSeasoning = Console.ReadLine();

    Seasoning seasoning = inputSeasoning?.ToLower() switch
    {
        "spicy" => Seasoning.SPICY,
        "salty" => Seasoning.SALTY,
        "sweet" => Seasoning.SWEET,
        _ => Seasoning.INVALID
    };

    return seasoning;
}

void DisplayMeal() => Console.WriteLine($"{meal.seasoing} {meal.ingredients} {meal.food}");

enum FoodType { 
    SOUP,
    STEW,
    GUMBO,
    INVALID
};
enum Ingredients
{
    MUSHROOMS,
    CHICKEN,
    CARROTS,
    POTATOES,
    INVALID
};
enum Seasoning
{
    SPICY,
    SALTY,
    SWEET,
    INVALID
};

