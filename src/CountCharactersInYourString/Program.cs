//https://www.codewars.com/kata/52efefcbcdf57161d4000091
var counts = Count("dwadwadsssssssaaawawa");

foreach (var item in counts)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.ReadKey();

static Dictionary<char, int> Count(string str)
{
    if (string.IsNullOrEmpty(str))
    {
        return new Dictionary<char, int>();
    }

    return str.GroupBy(c => c)
              .Select(c => new { Character = c.Key, Count = c.Count() })
              .ToDictionary(t => t.Character, t => t.Count);
}