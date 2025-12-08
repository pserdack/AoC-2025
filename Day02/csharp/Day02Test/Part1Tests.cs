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
        List<Tuple<int, int>> result = part1.SplitStringToInts(testString);

        //assert result
        var expectedResult = new List<Tuple<int, int>>()
        {
            new Tuple<int, int>(11,22),
            new Tuple<int, int>(95,115),
            new Tuple<int, int>(998,1012)
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
    public async Task Part1IdIsValid_CheckIfAGivenIdIsValid_ReturnsTrue(int id)
    {
        Part1 part1 = new();
        bool result = part1.IdIsValid(id);

        await Assert.That(result).IsTrue();
    }

    [Test]
    [Arguments(11)]
    [Arguments(123123)]
    public async Task Part1IdIsValid_CheckIfAGivenIdIsValid_ReturnsFalse(int id)
    {
        Part1 part1 = new();
        bool result = part1.IdIsValid(id);

        await Assert.That(result).IsFalse();
    }
}

