namespace Day03;

public class Part1
{
    public static int CalculateSolution(string input)
    {
        return input.Split('\n')
            .Select(it => it.Trim())
            .Select(FindJoltageForRow)
            .Sum();
    }
    
    internal static int FindJoltageForRow(string input)
    {
        var firstNumber = -1;
        var secondNumber = -1;
        for (var i = 0; i < input.Length; ++i)
        {
            var currentNumber = int.Parse(input[i].ToString());
            if (currentNumber > firstNumber && i != input.Length - 1)
            {
                firstNumber = currentNumber;
                secondNumber = 0;
            } else if (currentNumber > secondNumber)
            {
                secondNumber = currentNumber;
            }
        }

        return 10 * firstNumber + secondNumber;
    }
    
}