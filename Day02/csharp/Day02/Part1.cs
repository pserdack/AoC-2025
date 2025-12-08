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

    public bool IdIsValid(int id){
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
}

public static class IntExtension 
{
    extension(int input)
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