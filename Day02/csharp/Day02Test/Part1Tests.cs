using Day02;

namespace Day02Test;

class Part1Tests
{

    [Test]
    public async Task Part1SplitRanges_SplitStringIntoIntegerRanges_ReturnIntegerTouple()
    {
        //provide examples
        const string testString = "11-22,95-115,998-1012";
        
        //execute function
        Part1 part1 = new Part1();
        List<Tuple<long, long>> result = part1.SplitStringToInts(testString);

        //assert result
        var expectedResult = new List<Tuple<long, long>>()
        {
            new Tuple<long, long>(11,22),
            new Tuple<long, long>(95,115),
            new Tuple<long, long>(998,1012)
        };

        using (Assert.Multiple())
        {
            await Assert.That(result)
                .IsNotNull()
                .And.IsNotEmpty();
            await Assert.That(result.Count).IsEqualTo(3);
            await Assert.That(result[0]).IsEqualTo(expectedResult[0]);
            await Assert.That(result[1]).IsEqualTo(expectedResult[1]);
            await Assert.That(result[2]).IsEqualTo(expectedResult[2]);
        }

    }

    [Test]
    [Arguments(1)]
    [Arguments(13)]
    [Arguments(131)]
    [Arguments(1331)]
    public async Task Part1IdIsValid_CheckIfAGivenIdIsValid_ReturnsTrue(long id)
    {
        Part1 part1 = new();
        bool result = part1.IdIsValid(id);

        await Assert.That(result).IsTrue();
    }

    [Test]
    [Arguments(11)]
    [Arguments(123123)]
    public async Task Part1IdIsValid_CheckIfAGivenIdIsValid_ReturnsFalse(long id)
    {
        Part1 part1 = new();
        bool result = part1.IdIsValid(id);

        await Assert.That(result).IsFalse();
    }

    [Test]
    public async Task Part1GetInvalidIds_IterateRange_ReturnsInvalidIds()
    {
        Tuple<long,long> testRange = new Tuple<long,long>(11,33);
        long expectedResult = 66;
        Tuple<long,long> testRange2 = new Tuple<long,long>(998,1012);
        long expectedResult2 = 1010;

        Part1 part1 = new();
        long result = part1.GetInvalidIdsSumInRange(testRange);
        long result2 = part1.GetInvalidIdsSumInRange(testRange2);

        using (Assert.Multiple())
        {
            await Assert.That(result).IsEqualTo(expectedResult);
            await Assert.That(result2).IsEqualTo(expectedResult2);
        }
    }

    [Test]
    public async Task Par1GetSumOfInvalidIds_FindTheSumOfInvalidIdsOverRanges_ReturnSum()
    {
        var input = """
                    11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124
                    """;

        Part1 part1 = new();
        var result = part1.ProcessInput(input);

        await Assert.That(result).IsEqualTo(1227775554);
    }
}

