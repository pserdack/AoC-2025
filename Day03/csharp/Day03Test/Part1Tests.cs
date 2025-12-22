using Day03;

namespace Day03Test;

public class Part1Tests
{
    [Test]
    [Arguments("987654321111111", 98)]
    [Arguments("811111111111119", 89)]
    [Arguments("234234234234278", 78)]
    [Arguments("818181911112111", 92)]
    public async Task Part1_FindLargestJoltage_ReturnJoltage(string input, int expectedResult)
    {
        var result = Part1.FindJoltageForRow(input);

        using (Assert.Multiple())
        {
            await Assert.That(result).IsEqualTo(expectedResult);
        }
    }


    [Test]
    public async Task Part1_CalculateSolution_ReturnSolution()
    {
        const string input =
            """
            987654321111111
            811111111111119
            234234234234278
            818181911112111
            """;
        
        var result = Part1.CalculateSolution(input);

        await Assert.That(result).IsEqualTo(357);
    }
}