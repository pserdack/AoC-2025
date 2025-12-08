namespace Day02;

public class Part1
{

    public List<Tuple<long, long>> SplitStringToInts(string input)
    {
        return input
            .Split(',')
            .Select(it =>
            {
                var stringRange = it.Split('-');
                return new Tuple<long, long>(long.Parse(stringRange[0]), long.Parse(stringRange[1]));
            })
            .ToList();
    }

    public bool IdIsValid(long id){
        var length = id.ToString().Length;
        if (length % 2 != 1) 
        {
            // Consider/Ignore: int.ToString().Substring(0, length/2) -> int.firstHalf() ... int.secondHalf()
            if(id.FirstHalf() == id.SecondHalf())
            {
                return false;
            }
        }

        return true;
    }

    public long GetInvalidIdsSumInRange(Tuple<long, long> range)
    {
        var sum = 0L;
        for (var i = range.Item1; i <= range.Item2; ++i)
        {
            if (!IdIsValid(i))
            {
                sum += i;
            }
        }

        return sum;
    }

    public long ProcessInput(string input){
        var listOfRanges = SplitStringToInts(input);
        long runningSum = 0;
        foreach (var tuple in listOfRanges){
            runningSum += GetInvalidIdsSumInRange(tuple);
        }
        return runningSum;
    }
}


public static class IntExtension 
{
    extension(long input)
    {
        public string FirstHalf()
        {
            var inputString = input.ToString();
            return inputString.Substring(0, inputString.Length / 2);
        }

        public string SecondHalf()
        {
            var inputString = input.ToString();
            return inputString.Substring(inputString.Length / 2);
        }
    }
}

public static class ExtensionLong
{
    public static IEnumerable<long> Range(this long start, long count)
    {
        for (long i = start; i < start + count; i++)
        {
            yield return i;
        }
    }
}
