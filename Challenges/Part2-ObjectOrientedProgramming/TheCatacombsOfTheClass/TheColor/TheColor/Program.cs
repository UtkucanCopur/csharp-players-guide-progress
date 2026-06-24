Color a = new Color(35, 185, 234);
Color b = Color.Orange();

Console.WriteLine($"a: ({a._red},{a._green},{a._blue})");
Console.WriteLine($"b: ({b._red},{b._green},{b._blue})");


public class Color
{
    public byte _red {  get; }
    public byte _green { get; }
    public byte _blue { get; }


    public Color(byte red, byte green, byte blue)
    {
        _red = red;
        _green = green;
        _blue = blue;
    }

    public static Color White() => new Color(255,255,255);
    public static Color Black() => new Color(0,0,0);
    public static Color Red() => new Color(255, 0, 0);
    public static Color Orange() => new Color(255, 165, 0);
    public static Color Yellow() => new Color(255, 255, 0);
    public static Color Green() => new Color(0, 128, 0);
    public static Color Blue() => new Color(0, 0, 255);
    public static Color Purple() => new Color(128, 0, 128);
}