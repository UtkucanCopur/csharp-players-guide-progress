
Console.WriteLine("1-Elite Arrow 2-Beginner Arrow 3-Marksman Arrow 4-Custom");
int firstSelection = Convert.ToInt32(Console.ReadLine());
switch (firstSelection)
{
    case 1:
        Arrows newEliteArrow = Arrows.CreateEliteArrow();
        float eliteCost = newEliteArrow.GetCost();
        Console.WriteLine($"{newEliteArrow.ArrowHead}, {newEliteArrow.Fletching},{newEliteArrow.Shaft} cost: {eliteCost}");
        break;
    case 2:
        Arrows newBeginnerArrow = Arrows.BeginnerArrow();
        float beginnerCost = newBeginnerArrow.GetCost();
        Console.WriteLine($"{newBeginnerArrow.ArrowHead}, {newBeginnerArrow.Fletching},{newBeginnerArrow.Shaft} cost: {beginnerCost}");
        break;
    case 3:
        Arrows newMarksmanArrow = Arrows.MarksmanArrow();
        float marksmanCost = newMarksmanArrow.GetCost();
        Console.WriteLine($"{newMarksmanArrow.ArrowHead}, {newMarksmanArrow.Fletching},{newMarksmanArrow.Shaft} cost: {marksmanCost}");
        break;
    case 4:
        DisplayArrowHead();
        string answerArrowHead = (Console.ReadLine() ?? "").ToUpper();
        ArrowHead userArrowHead = Enum.Parse<ArrowHead>(answerArrowHead);
        DisplayFletching();
        string answerFletching = (Console.ReadLine() ?? "").ToUpper();
        Fletching userFletching = Enum.Parse<Fletching>(answerFletching);
        DisplayShaft();
        int userShaft = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
        if (userShaft > 100) userShaft = 100;
        if (userShaft < 60) userShaft = 60;
        Arrows arrow1 = new Arrows(userArrowHead, userFletching, userShaft);
        float cost = arrow1.GetCost();
        Console.WriteLine($"{arrow1.ArrowHead}, {arrow1.Fletching},{arrow1.Shaft} cost: {cost}");
        break;

}


void DisplayArrowHead()
{
    Console.WriteLine("Hello");
    Console.WriteLine("Pick ArrowHead: STEEL, WOOD, OBSIDIAN");
}
void DisplayFletching()
{
    Console.WriteLine("Pick Fletching: PLASTIC, TURKEYFEATHERS, GOOSEFEATHERS,");

}

void DisplayShaft()
{
    Console.WriteLine("Pick Shaft between 60 and 100");
}

class Arrows
{
    private ArrowHead _arrowHead;
    private Fletching _fletching;
    private int _shaft;

    public ArrowHead ArrowHead
    {
        get => _arrowHead;
        set => _arrowHead = value;
    }

    public Fletching Fletching
    {
        get => _fletching;
        set => _fletching = value;
    }

    public int Shaft
    {
        get => _shaft;
        set => _shaft = value;
    }



    public int Value
    {
        get { return _shaft; }
        set
        {
            if (value < 60)
                _shaft = 60;
            else if (value > 100)
                _shaft = 100;
            else
                _shaft = value;
        }
    }


    public Arrows()
    {
        _arrowHead = ArrowHead.NOTSELECTED;
        _fletching = Fletching.NOTSELECTED;
        _shaft = -1;
    }

    public Arrows(ArrowHead arrowHead, Fletching fletching, int shaft)
    {
        _arrowHead = arrowHead;
        _fletching = fletching;
        _shaft = shaft;
        
    }

    public static Arrows CreateEliteArrow()
    {
        Arrows newArrow = new Arrows();
        newArrow.ArrowHead = ArrowHead.STEEL;
        newArrow.Fletching = Fletching.PLASTIC;
        newArrow.Shaft = 95;
        return newArrow;
    }

    public static Arrows MarksmanArrow()
    {
        Arrows newArrow = new Arrows();
        newArrow.ArrowHead = ArrowHead.STEEL;
        newArrow.Fletching = Fletching.GOOSEFEATHERS;
        newArrow.Shaft = 65;
        return newArrow;
    }

    public static Arrows BeginnerArrow()
    {
        Arrows newArrow = new Arrows();
        newArrow.ArrowHead = ArrowHead.WOOD;
        newArrow.Fletching = Fletching.GOOSEFEATHERS;
        newArrow.Shaft = 75;
        return newArrow;
    }

    public float GetCost()
    {
        float cost = 0;

        switch (_arrowHead)
        {
            case ArrowHead.STEEL:
                cost += 10;
                break;
            case ArrowHead.WOOD:
                cost += 3;
                break;
            case ArrowHead.OBSIDIAN:
                cost += 5;
                break;
            case ArrowHead.NOTSELECTED:
                break;
        }
        switch (_fletching)
        {
            case Fletching.PLASTIC:
                cost += 10;
                break;
            case Fletching.TURKEYFEATHERS:
                cost += 5;
                break;
            case Fletching.GOOSEFEATHERS:
                cost += 3;
                break;
            case Fletching.NOTSELECTED:
                break;
        }

        float shaftCost = _shaft * 0.05f;

        cost += shaftCost;

        return cost;
    }


}

enum ArrowHead
{
    STEEL,
    WOOD,
    OBSIDIAN,
    NOTSELECTED
}

enum Fletching
{
    PLASTIC,
    TURKEYFEATHERS,
    GOOSEFEATHERS,
    NOTSELECTED
}