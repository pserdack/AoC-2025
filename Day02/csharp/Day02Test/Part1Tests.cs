namespace Day02Test;

class Part1Tests
{
    public async Task Part1SplitRanges_SplitStringIntoIntegerRanges_ReturnIntegerTouple()
    {
        //provide examples
        const string testString = "11-22,95-115,998-1012";
        
        //execute function
        Part1 part1 = new Part1();
        List<Tuple<int, int>> result = part1.SplitStringToListOfIntTouples(testString);

        //assert result
        var expectedResult = new List<Tuple<int, int>>()
        {
            new Tuple<int, int>(11,22),
            new Tuple<int, int>(95,115),
            new Tuple<int, int>(998,1012)
        };
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}