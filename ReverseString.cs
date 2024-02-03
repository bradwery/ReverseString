namespace ReverseStringDemo;


public static class ReverseString
{
    public static string ArrayReverse(string value)
    {
        char[] chars = value.ToArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static string LinqReverse(string value)
    {
        return new string(value.Reverse().ToArray());
    }

    public static string UsingRecursion(string value)
    {
        if(value.Length <= 1) return value;

        return UsingRecursion(value[1..]) + value[0];
    }

    public static string MeetInTheMiddle(string value)
    {
        char[] valueArray = new char[value.Length];

        for(int i = 0; i < value.Length / 2 + 1; i++) {
            valueArray[i] = value[value.Length - i - 1];
            valueArray[value.Length - i - 1] = value[i];
        }

        List<string> one = new List<string>();

        List<string> two = new List<string>();

        var test = one.Where(a => a == "a").ToList();
        var test2 = two.Except(test).ToList();

        return new string(valueArray);
    }

    public static string UsingSpan(string value)
    {
        Span<char> chars = new char[value.Length];
        value.AsSpan().CopyTo(chars);
        chars.Reverse();
        return new string(chars);
    }
}