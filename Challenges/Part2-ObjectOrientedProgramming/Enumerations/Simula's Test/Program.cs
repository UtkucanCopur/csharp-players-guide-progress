Status chestStatus = Status.LOCKED;



while (true)
{
    Console.WriteLine($"The chest is {chestStatus}. What do you want to do?");
    string? choice = Console.ReadLine();
    choice = choice?.ToLower();
    if (choice == "unlock" && chestStatus == Status.LOCKED) chestStatus = Status.CLOSED;
    else if (choice == "close" && chestStatus == Status.OPEN) chestStatus = Status.CLOSED;
    else if (choice == "open" && chestStatus == Status.CLOSED) chestStatus = Status.OPEN;
    else if (choice == "lock" && chestStatus == Status.CLOSED) chestStatus = Status.LOCKED;
    else Console.WriteLine("Enter proper command");
}


enum Status
{
    OPEN,
    CLOSED,
    LOCKED
}


