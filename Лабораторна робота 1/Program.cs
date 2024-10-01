using static System.Math;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input value x:");
        double x = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Value x = " + x);
        double firstEx = Pow(x, 3) + Sqrt(Abs(3 * x));
        double secondEx = Pow(x, 2) + Exp(x);
        double thrsev = Pow(firstEx / secondEx, 3 / 7);
        double lg3 = Pow(Log10(thrsev), 3);
        double ln4 = Pow(Log(lg3), 4);

        double thrfiv = Pow(x, 3 / 5);
        double thirdEx = Pow(x, 3) + 7.8;
        double sin = Pow(Sin(thirdEx), 2);
        double forthEx = thrfiv / sin;
        double result = ln4 - forthEx;
        Console.WriteLine(result);
        Console.ReadLine();
    }
}