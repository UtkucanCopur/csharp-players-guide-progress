int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?");
    if (guess > number) Console.WriteLine($"{guess} is too high.");
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");




int AskForNumber(string text)
{
    Console.WriteLine(text);
    int response = Convert.ToInt32(Console.ReadLine());
    return response;
}


int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");

int AskForNumberInRange(string text, int min, int max)
{
    do
    {
        
        int textNum = AskForNumber(text);
        if (textNum >= min && textNum <= max) return textNum;

    } while (true);


}

