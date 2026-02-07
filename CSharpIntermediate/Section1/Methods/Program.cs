using Methods;

var calculator = new Calculator();
Console.WriteLine(calculator.Add(1, 2));
Console.WriteLine(calculator.Add(1, 2, 3));
Console.WriteLine(calculator.Add(1, 2, 3, 4));

UsePoints();

static void UsePoints()
{
    try
    {
        var point = new Point(10, 20);
        point.Move(null);
        Console.WriteLine($"Point is at {point.X}, {point.Y}");

        point.Move(100, 200);
        Console.WriteLine($"Point is at {point.X}, {point.Y}");
    }
    catch (Exception)
    {
        Console.WriteLine("An unexpected error occured.");
    }
}