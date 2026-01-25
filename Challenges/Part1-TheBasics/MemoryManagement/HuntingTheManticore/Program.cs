//VARIABLES
int cityHealth = 15;
int manticoreHealth = 10;
int round = 1;
int range;
int expectedDamage;
bool gameStatus = false;

range = Player1SelectRange("How far away from the city do you want to station the Manticore?", 100, 0);
Console.Clear();

//GAME LOOP
while (!gameStatus)
{
    
    expectedDamage = DamageCalculator();
    DisplayStatus();
    ManticoreAttack();
    PlayerAttack();
    EndGameChecker(cityHealth, manticoreHealth);
    round++;
}

//Distance for manticore
int Player1SelectRange(string text, int max, int min)
{
    int number;
    while (true)
    {
        Console.WriteLine(text);
        number = Convert.ToInt32(Console.ReadLine());
        if (number > max) Console.WriteLine("Decrease your number");
        else if (number < min) Console.WriteLine("Increase your number");
        else return number;

    }
}

//FEEDBACK TO PLAYER
void DisplayStatus()
{
    Console.ResetColor();
    Console.WriteLine("---------------------------");
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth} Manticore: {manticoreHealth} ");
    Console.WriteLine($"The cannon is expected to deal {expectedDamage} damage this round");
}

//CALCULATING THE DAMAGE
int DamageCalculator()
{
    if (round % 3 == 0 && round % 5 == 0) return 10;
    else if (round % 3 == 0) return 3;
    else if (round % 5 == 0) return 3;
    else return 1;
}

void ManticoreAttack()
{
    if (cityHealth > 0) cityHealth--;
    
}

void PlayerAttack()
{
    Console.WriteLine("Enter desired cannon range: ");
    int shootingRange = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(CheckRange(shootingRange, range));

}

string CheckRange(int shootingRange, int range)
{
    if (shootingRange < range)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        return "That round FELL SHORT of the target";
    }
    else if (shootingRange > range)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        return "That round OVERSHOT the target";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        manticoreHealth -= expectedDamage;
        return "That round was a DIRECT HIT!";
        
    }
}

void EndGameChecker(int cityHealth, int manticoreHealth)
{
    if (manticoreHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("YOU WIN!!");
        gameStatus = true;
    } else if (cityHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOU LOSE!!");
        gameStatus = true;
    } 
}
