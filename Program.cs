using ReverseStringDemo;

#if DEBUG
    string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!";

    Console.WriteLine(ReverseString.ArrayReverse(s));
    Console.WriteLine(ReverseString.LinqReverse(s));
    Console.WriteLine(ReverseString.UsingRecursion(s));
    Console.WriteLine(ReverseString.MeetInTheMiddle(s));
    Console.WriteLine(ReverseString.UsingSpan(s));
    
#else
    BenchmarkDotNet.Running.BenchmarkRunner.Run(typeof(Benchmarks));
#endif
