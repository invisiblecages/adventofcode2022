/*

*/
namespace Day03;

internal class Program
{
    static void Main(string[] args)
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
        string path = Path.Combine(projectDirectory, "day03.txt");

        string[] data = File.ReadAllLines(path);
    }
}