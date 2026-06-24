
while (true)
{
    Console.WriteLine("Enter your password");
    string input = Console.ReadLine() ?? "";
    PasswordValidator a = new PasswordValidator(input);
    Console.WriteLine($"Your password: {a.Password.ToString()}");
}




public class PasswordValidator
{
    public string Password { get; private set; } = "-1";

    //Class içinde olmıcak password
    public PasswordValidator(string password)
    {
        if (password.Length <= 6 || password.Length >= 13)
        {
            Console.WriteLine("Length Problem");
            return;
        }

        foreach (char c in password)
        {
            if (char.IsUpper(c) || char.IsLower(c) || char.IsDigit(c))
            {
                Console.WriteLine("Try again");
                return;
            }
            
        }

        if (password.Contains('T') || password.Contains('&')) return;

        Password = password;

    }
}

