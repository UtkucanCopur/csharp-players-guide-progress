int RecursiveMethod(int number)
{
    if (number > 0)
    {
        Console.WriteLine(number);
        number--;
        return RecursiveMethod(number);
    }
    return -1;
}

RecursiveMethod(10);