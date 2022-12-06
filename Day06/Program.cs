namespace Day06;

internal class Program
{
    static void Main(string[] args)
    {
        string path = $"../../../../input/day06.txt";
        string[] input = File.ReadAllLines(path);
        int characters = 14;

        for (int i = 0; i < input[0].Length - characters + 1; i++)
        {
            string res = "";
            int index = i + characters;

            for (int j = 0; j < characters; j++)
                res += input[0][i + j];

            if (res.Distinct().Count() == characters)
            {
                Console.WriteLine($"{index}:{res}");
                break;
            }
        }
    }
}