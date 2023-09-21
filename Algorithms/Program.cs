// See https://aka.ms/new-console-template for more information
namespace Algorithms;
using System;



class EntryPoint
{


    public static void Main(String[] args)
    {
        int[] scores = { 97, 92, 81, 60 };

        // Define the query expression.
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        // Execute the query.
        foreach (int i in scoreQuery)
        {
            if(i == 92){
                break;
            }
            Console.Write(i + " ");
        }

        Console.WriteLine("-- >>> ");

        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }
    }
}
