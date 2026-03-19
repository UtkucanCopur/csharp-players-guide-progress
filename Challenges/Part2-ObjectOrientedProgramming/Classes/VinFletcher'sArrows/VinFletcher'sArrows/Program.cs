

DisplayArrowHead();
string answerArrowHead = (Console.ReadLine() ?? "").ToUpper();
ArrowHead userArrowHead = Enum.Parse<ArrowHead>(answerArrowHead);
DisplayFletching();
string answerFletching = (Console.ReadLine() ?? "").ToUpper();
Fletching userFletching = Enum.Parse<Fletching>(answerFletching);
DisplayShaft();
int userShaft = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
if (userShaft >100) userShaft = 100;
if (userShaft < 60) userShaft = 60;
Arrows arrow1 = new Arrows(userArrowHead,userFletching,userShaft);
float cost = arrow1.GetCost();

Console.WriteLine($"{arrow1._arrowHead}, {arrow1._fletching},{arrow1._shaft} cost: {cost}");

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
    public ArrowHead _arrowHead;
    public Fletching _fletching;
    public int _shaft;

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

