Console.WriteLine("Enter your password");
int password = Convert.ToInt32(Console.ReadLine());
Door door = new Door(password);
Console.WriteLine($"Door is {door.Status}");
while (true)
{
    Console.WriteLine("1-open 2-close 3-lock 4-unlock 5-change password");
    string input = Console.ReadLine() ?? "-1";
    _ = input switch
    {
        "1" => door.Open(),
        "2" => door.Close(),
        "3" => door.Lock(),
        "4" => door.Unlock(),
        "5" => door.CheckPassword(),
        _ => false
    };
    Console.WriteLine($"Door is {door.Status}");
}



public enum DoorStatus
{
    LOCKED,
    OPEN,
    CLOSED
}


public class Door
{
    public DoorStatus Status { get; private set; }
    private int _password;

    public Door(int initialPassword)
    {
        Status = DoorStatus.OPEN;
        this._password = initialPassword;
    }

    public bool Close() { if (Status == DoorStatus.OPEN) {Status = DoorStatus.CLOSED; } return true; }
    public bool Open() { if (Status == DoorStatus.CLOSED) {Status = DoorStatus.OPEN; }  return true; }
    public bool Lock() { if (Status == DoorStatus.CLOSED) {Status = DoorStatus.LOCKED; }  return true; }
    public bool Unlock()
    {
        if (Status == DoorStatus.LOCKED)
        {
            Console.WriteLine("Enter your password");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == this._password)
            {
                Status = DoorStatus.CLOSED;
                return true;
            }
            else
            {
                Console.WriteLine("Wrong password");
                
                return false;
            }
        }
        else return false;
    }
    public bool ChangePassword(int input, int newPassword) { if (input == this._password) { this._password = newPassword; return true; } else { return false; } }
    public bool CheckPassword() { 
        if (Status == DoorStatus.LOCKED)
        {
            Console.WriteLine("Enter your password and new password");
            int currentPassword = Convert.ToInt32(Console.ReadLine());
            int newPassword = Convert.ToInt32(Console.ReadLine());
            bool isPasswordChanged = ChangePassword(currentPassword, newPassword);
            if (isPasswordChanged) { Console.WriteLine("Your password changed"); return true; }
            else { Console.WriteLine("Wrong Password"); return false; }
        }
        
        return false;
    }
}
