using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main()
        {
            UserArray arr1 = new UserArray();
            arr1.fillRand(10);
            Console.WriteLine(arr1);

            Console.WriteLine($"Number of less elements: {arr1.NumberOfLess(50)}");
            Console.WriteLine(arr1.CountDistinct());
            Console.WriteLine(arr1.EqualToValue(5));
        }
    }
}
