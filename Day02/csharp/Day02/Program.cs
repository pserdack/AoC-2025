using Day02;

string fileName = "../test.txt";

if (args.Length > 0 && args[0] == "paul")
{
    fileName = "../testPaul.txt";
} else if (args.Length > 0 && args[0] == "micha")
{
    fileName = "Day02/testMicha.txt";
}

Part1 part1 = new();
var input = File.ReadAllText(fileName);

Console.WriteLine(part1.ProcessInput(input));
