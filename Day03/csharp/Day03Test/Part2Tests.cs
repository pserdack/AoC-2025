using Day03;

namespace Day03Test;

public class Part2Tests
{
    [Test]
    [Arguments("987654321111111", 987654321111)]
    [Arguments("811111111111119", 811111111119)]
    [Arguments("234234234234278", 434234234278)]
    [Arguments("818181911112111", 888911112111)]
    public async Task Part2_FindLargestJoltage_ReturnJoltage(string input, long expectedResult)
    {
        var result = Part2.FindJoltageForRow(input);

        await Assert.That(result).IsEqualTo(expectedResult);
    }

    [Test]
    public async Task Part2_AssembleBigNumber()
    {
        var result = Part2.AssembleBigNumber([9, 8, 7, 6, 5, 4, 3, 2, 1, 0]);

        await Assert.That(result).IsEqualTo(9876543210L);
    }

    [Test]
    public async Task Part2_NumberOfZeros()
    {
        var result = Part2.PowerOfTen(4);
        await Assert.That(result).IsEqualTo(10_000);

        result = Part2.PowerOfTen(0);
        await Assert.That(result).IsEqualTo(1);
    }
}