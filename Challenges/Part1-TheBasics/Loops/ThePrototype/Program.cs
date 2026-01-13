bool control = false;

while (!control)
{
    Console.WriteLine("User 1, enter a number between 0 and 100:");
    int.TryParse(Console.ReadLine(), out int user1Input);

    if (user1Input < 100 && user1Input > 0)
    {
        Console.Clear();
        bool isTrue = false;
        while (!isTrue)
        {
            Console.WriteLine("User 2, guess the number.");
            int.TryParse(Console.ReadLine(), out int user2Input);
            if (user2Input > user1Input)
            {
                Console.WriteLine($"{user2Input} is too high");
            }
            else if (user2Input < user1Input)
            {
                Console.WriteLine($"{user2Input} is too low");
            }
            else
            {
                Console.WriteLine("You guessed the number!");
                isTrue = true;
                control = true;
            }
        }

    }
    else
    {

        Console.WriteLine("Please give the number between 0 and 100");
    }
}





