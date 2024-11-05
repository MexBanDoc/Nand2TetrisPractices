namespace IEEE_754;

public static class Class
{
    public static void Main()
    {
        Sum();
        // Associativity();
        // DifferentOrder();
        // Cycle();
        // NanAndInfinity();
        // Round();
    }

    private static void Sum()
    {
        Console.WriteLine(0.1 + 0.2 == 0.3);
        Console.WriteLine("{0:f24}", 0.1);
        Console.WriteLine("{0:f24}", 0.2);
        Console.WriteLine("{0:f24}", 0.3);
        Console.WriteLine("{0:f24}", 0.1 + 0.2);
    }

    private static void Associativity()
    {
        Console.WriteLine("{0:f24}", (0.2 + 0.7) + 0.1);
        Console.WriteLine("{0:f24}", 0.2 + (0.7 + 0.1));
    }

    private static void DifferentOrder()
    {
        var x = 16777216.0f;
        var y = 1.0f;
        Console.WriteLine((x - x) + y);
        Console.WriteLine((x + y) - x);
    }

    private static void Cycle()
    {
        for (double i = 9007199254740990.0; i < 9007199254740994.0; i += 1.0)
        {
            Console.WriteLine(i);
        }
    }

    private static void NanAndInfinity()
    {
        Console.WriteLine(Math.Pow(double.NaN, 1));
        Console.WriteLine(Math.Pow(double.NaN, 12));
        Console.WriteLine(Math.Pow(double.NaN, -5));
        // Console.WriteLine(Math.Pow(double.NaN, double.NaN));

        // ReSharper disable once EqualExpressionComparison
        // ReSharper disable once CompareOfFloatsByEqualityOperator
        // Console.WriteLine(double.NaN == double.NaN);

        // Console.WriteLine(Math.Pow(double.NaN, 0));

        // Console.WriteLine(1/double.PositiveInfinity);
        // Console.WriteLine(1/double.NegativeInfinity);
        // Console.WriteLine(1/double.PositiveInfinity == 1/double.NegativeInfinity);
        // Console.WriteLine(double.PositiveInfinity == double.NegativeInfinity);
    }

    private static void Round()
    {
        Console.WriteLine($"[2.5] - [1.5]: {Math.Round(2.5) - Math.Round(1.5)}");
        Console.WriteLine($"[3.5] - [2.5]: {Math.Round(3.5) - Math.Round(2.5)}");
        // Console.WriteLine($"[2.5] - [1.5]: {Math.Round(2.5, MidpointRounding.AwayFromZero) - Math.Round(1.5, MidpointRounding.AwayFromZero)}");
        // Console.WriteLine($"[3.5] - [2.5]: {Math.Round(3.5, MidpointRounding.AwayFromZero) - Math.Round(2.5, MidpointRounding.AwayFromZero)}");
        // Console.WriteLine($"Floor [2.5]: {Math.Floor(2.5)}");
        // Console.WriteLine($"Floor [-2.5]: {Math.Floor(-2.5)}");
        // Console.WriteLine($"Ceiling [2.5]: {Math.Ceiling(2.5)}");
        // Console.WriteLine($"Ceiling [-2.5]: {Math.Ceiling(-2.5)}");
        // Console.WriteLine($"Truncate [2.5]: {Math.Truncate(2.5)}");
        // Console.WriteLine($"Truncate [-2.5]: {Math.Truncate(-2.5)}");
    }
}