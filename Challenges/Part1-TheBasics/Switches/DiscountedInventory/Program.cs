Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
int itemNumber = Convert.ToInt32(Console.ReadLine());

string item = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Apologies. I do not know that one"
};

int cost = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1,
    _ => -1
};

Console.WriteLine("What is your name?");
string name = Console.ReadLine() ?? "";
if (name.ToLower() == "utkucan")
{
    float newcost = cost/2f;
    Console.WriteLine($"{item} cost {newcost} gold");
} else
{
    Console.WriteLine($"{item} cost {cost} gold");
}

