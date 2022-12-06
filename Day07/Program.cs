namespace Day07;

internal class Program
{
    private static readonly string path = $"../../../../input/day07.txt";
    private static readonly string[] input = File.ReadAllLines(path);

    static void Day1()
    {
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[i]);
        }
    }

    static void Day2()
    {

    }

    static void Main(string[] args)
    {
        Day1();
        Day2();
    }
}