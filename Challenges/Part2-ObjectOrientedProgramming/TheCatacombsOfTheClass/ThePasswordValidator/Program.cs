


while (true)
{
    Console.WriteLine("Enter password");
    string password = Console.ReadLine() ?? "-1";
    PasswordValidator.Control(password);

}


public class PasswordValidator
{

    public PasswordValidator() { }


    public static void Control(string password)
    {
        if (password.Length < 6 || password.Length > 13) return;
        int upperIndex = 0;
        int lowerIndex = 0;
        int digitIndex = 0;
        foreach (char c in password)
        {
            //Aali1241
            if (char.IsUpper(c)) upperIndex++;
            if (char.IsLower(c)) lowerIndex++;
            if (char.IsDigit(c)) digitIndex++;
            if (c == 'T' || c == '&')
            {
                Console.WriteLine("Invalid Password");
                return;
            }
            if (upperIndex != 0 && lowerIndex != 0 && digitIndex != 0)
            {
                Console.WriteLine("Valid Password");
                return;
            }
            
        }
        Console.WriteLine("Invalid password");
    }
}