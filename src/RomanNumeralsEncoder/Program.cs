using System;
using System.Text;

Console.WriteLine(Solution(949));

string Solution(int n)
{
    Dictionary<int, char> chars = new Dictionary<int, char>()
    {
        [1] = 'I',
        [5] = 'V',
        [10] = 'X',
        [50] = 'L',
        [100] = 'C',
        [500] = 'D',
        [1000] = 'M'
    };

    StringBuilder stringBuilder = new StringBuilder();

    while (n > 0)
    {
        var ch = chars.Last(number => n - number.Key >= 0);

        stringBuilder.Append(ch.Value);

        n -= ch.Key;
    }

    

    return stringBuilder.ToString();
}