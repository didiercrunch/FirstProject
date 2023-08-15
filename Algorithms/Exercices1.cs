namespace Algorithms;
using System;
using Algorithms.NumberTheory;

class SolutionExercices1 {

    public static string removeTitle(string header)
    {
        int idx = header.IndexOf(".");
        return header.Substring(idx + 1);
    }

    public static void printEachDirectoryOnPath(string path)
    {
        string[] subs = path.Split(':');

        foreach (var sub in subs)
        {
            Console.WriteLine(sub);
        }
    }

    public static void Main_(String[] args){
        // {titre}.{sous-titre}.{sous-sous- titre}
        // 4.56.2 -> 56.2
        // 4.b.ii  -> b.ii
        string header = "4.56.2";
        Console.WriteLine(removeTitle("4.56.2")); // "56.2"
        Console.WriteLine(removeTitle("4.b.ii")); // "b.ii"
        Console.WriteLine(removeTitle("")); // ""
        Console.WriteLine(removeTitle("4.b")); // "b"


        string? path = Environment.GetEnvironmentVariable("PATH");
        printEachDirectoryOnPath(path ?? "");
    }
}