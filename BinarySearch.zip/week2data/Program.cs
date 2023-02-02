using System;

namespace DataStructuresBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 13, 32, 45, 56, 67, 1, 2, 5};

            /*foreach (int i in array)
            {
     
                Console.WriteLine(i);
            }*/

            int findvalueindex = BinarySearch.Binarysearch(array, 56);
            Console.WriteLine($"Find value index in array: " + findvalueindex);
           
           
        }
    }
}

