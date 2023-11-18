//https://www.codewars.com/kata/54da539698b8a2ad76000228

Console.WriteLine(IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));

static bool IsValidWalk(string[] walk)
{
    if (walk.Length != 10)
    {
        return false;
    }

    var groups = walk.GroupBy(step => step)
                     .ToDictionary(step => step.Key, step => step.Count());

    return groups.GetValueOrDefault("s") == groups.GetValueOrDefault("n") &&
           groups.GetValueOrDefault("w") == groups.GetValueOrDefault("e");
}