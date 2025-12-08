// See https://aka.ms/new-console-template for more information

string fileName = "../test.txt";

if (args.Length > 0 && args[0] == "paul")
{
    fileName = "../testPaul.txt";
} else if (args.Length > 0 && args[0] == "Day02/micha")
{
    fileName = "testMicha.txt";
}

Console.WriteLine(File.ReadAllText(fileName));
