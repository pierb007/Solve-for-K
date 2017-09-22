using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_for_K
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to be checked for k-periodicity.");
            Char[] input = Console.ReadLine().ToCharArray();
            Console.WriteLine("K={0}", ((from c in input select c).Distinct().Count()).ToString());
            Console.ReadKey();
        }
    }
}
