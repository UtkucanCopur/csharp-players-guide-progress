
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 14; j++)
    {
        Card card = new Card((Colors)i, (Ranks)j);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}

public enum Colors
{
    RED,
    GREEN,
    BLUE,
    YELLOW
}
public enum Ranks
{
    ONE,
    TWO,
    THREE,
    FOUR,
    FIVE,
    SIX,
    SEVEN,
    EIGHT,
    NINE,
    TEN,
    Dollar,   
    Percent,  
    Caret,    
    Ampersand
}

public class Card
{
    public Colors Color { get; }
    public Ranks Rank { get; }  


    public Card(Colors color, Ranks rank)
    {
        Color = color;
        Rank = rank;
    }


    public static string FindCardType(Card card)
    {
        return card.Rank switch
        {
            Ranks.Ampersand => "Ampersand",
            Ranks.Dollar => "$",
            Ranks.Caret => "^",
            Ranks.Percent => "%",
            _ => "Number"
        };
        
    }
}


//Answer to the question: we used color as a tool here. We don't need to create a whole class, we just need color names.