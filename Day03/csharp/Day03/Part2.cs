namespace Day03;

public class Part2
{
    public static long CalculateSolution(string input)
    {
        return input.Split('\n')
            .Select(it => it.Trim())
            .Select(FindJoltageForRow)
            .Sum();
    }
    
    //   0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 Index
    //   9  8  7  6  5  4  3  2  1  1  1  1  1  1  1 Number
    internal static long FindJoltageForRow(string input)
    {
        int[] numbers = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        for (var i = 0; i < input.Length; ++i)
        {
            var currentNumber = int.Parse(input[i].ToString());

            for (var indexInNumbers = 0; indexInNumbers < numbers.Length; ++indexInNumbers)
            {
                if (numbers.Length - indexInNumbers <= input.Length - i && currentNumber > numbers[indexInNumbers])
                {
                    numbers[indexInNumbers] = currentNumber;
                    ResetNumbersStartingAtIndex(numbers, indexInNumbers + 1);
                    break;
                }
            }
        }

        return AssembleBigNumber(numbers);
    }

    private static void ResetNumbersStartingAtIndex(int[] numbers, int index)
    {
        for (var i = index; i < numbers.Length; ++i)
        {
            numbers[i] = 0;
        }
    }

    internal static long AssembleBigNumber(int[] numbers)
    {
        long result = 0L;
        for (var i = 0; i < numbers.Length; ++i)
        {
            result += numbers[i] * PowerOfTen(numbers.Length - i - 1);
        }

        return result;
    }

    internal static long PowerOfTen(int numberOfZeros)
    {
        var result = 1L;
        for (var i = 0; i < numberOfZeros; ++i)
        {
            result *= 10;
        }

        return result;
    }
}