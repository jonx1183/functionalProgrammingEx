using System;
using Microsoft.VisualBasic;
public class TupleEx1
{
    public static void TupleEx1Func(){

        Tuple<int, string> t1 = new Tuple<int, string>(1, "Test1");

        var t2 = Tuple.Create(2, "Test2"); 

        var t3 = (3, "Test3");

        Console.WriteLine($"T1 = {t1.Item1} {t1.Item2}");
        Console.WriteLine($"T2 = {t2.Item1} {t2.Item2}");
        Console.WriteLine($"T3 = {t3.Item1} {t3.Item2}");

    }

}