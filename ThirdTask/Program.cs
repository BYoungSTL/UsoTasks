﻿// Implement the UniqueNames method. When passed two arrays of names, it will return an array containing the names that appear in either or both arrays. 
// The returned array should have no duplicates.
// For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'}, new string[]{'Olivia', 'Sophia', 'Emma'}) 
// should return an array containing Ava, Emma, Olivia, and Sophia in any order.

namespace ThirdTask
{
    internal class Program
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            return new HashSet<string>(names1.Concat(names2)).ToArray();
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
}
