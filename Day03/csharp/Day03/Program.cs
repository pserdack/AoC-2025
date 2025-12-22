using Day03;

if (args.Length > 0 && args[0] == "part1")
{
    var input = File.ReadAllText("../input.txt").Trim();
    var solution = Part1.CalculateSolution(input);
    Console.WriteLine($"Solution Part1: {solution}");
}