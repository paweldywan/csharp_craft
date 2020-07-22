using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_craft
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = args;


            //int x; Tego ma nie być, bo jest niepotrzebne. Traktować warningi jak errory.
            var tester = new PalindromeTester();
            var palindrome = tester.IsPalindrome("too bad i hid a bo");
            Console.WriteLine(palindrome);


            Console.ReadLine();
        }
    }
}
