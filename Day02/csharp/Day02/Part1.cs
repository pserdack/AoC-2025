namespace Day02;

public class Part1
{

    public List<Tuple<int, int>> SplitStringToInts(string input)
    {
        return input
            .Split(',')
            .Select(it =>
            {
                var stringRange = it.Split('-');
                return new Tuple<int, int>(int.Parse(stringRange[0]), int.Parse(stringRange[1]));
            })
            .ToList();
    }

}
