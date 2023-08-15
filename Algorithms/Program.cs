// See https://aka.ms/new-console-template for more information
namespace Algorithms;
using System;
using Algorithms.NumberTheory;

class Program
{

    public static void printEachDirectoryOnPath(string path)
    {
        string[] subs = path.Split(':');

        foreach (var sub in subs)
        {
            Console.WriteLine(sub);
        }
    }


    public static void Main(String[] args)
    {
        Point point = new Point(0, 0);
        Point point2 = new Point(10, 10);
        Console.WriteLine("La valeure de X de point est: " + point.X());
        Console.WriteLine("La valeure de X de point2 est: " + point2.X());

    }
}
