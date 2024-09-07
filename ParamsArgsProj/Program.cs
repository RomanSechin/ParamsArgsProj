internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("For counting average write numbers, other for quit:");
        decimal[] numbers = { };
        decimal temp;
        while (true) {
            if (decimal.TryParse(Console.ReadLine(), out temp))
            {
                numbers = [..numbers, temp];
            }
            else 
            {
                break;
            }
        }
        Console.WriteLine($"Average = {Average(numbers)}");
    }

    public static double Average(params decimal[] numbers) { 
        return (double) numbers.Average(x => x);
    }
}