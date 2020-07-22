using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_craft
{
    public class PalindromeTester
    {
        /// <summary>
        /// Do niczego
        /// </summary>
        /// <param name="strInput">Nazwy parametrów, zmiennych nie powinny zawierać nazwy typu, bo typ wynika z sygnatury i nic nie wnosi</param>
        /// <returns>Infomacja czy dany łańcuch znaków jest palindromem</returns>
        public bool Test(string strInput)
        {
            string strTrimmed = strInput.Replace(" ", "");

            string strReversed = new string(strTrimmed.Reverse().ToArray());

            return strReversed.Equals(strReversed);
        }

        /// <summary>
        /// Lepsze
        /// </summary>
        /// <param name="input">Nazwa parametru jest ok</param>
        /// <returns>Infomacja czy dany łańcuch znaków jest palindromem</returns>
        public bool Check(string input)
        {
            input = input.Replace(" ", "");

            var reversed = new string(input.Reverse().ToArray());

            return reversed.Equals(input);
        }

        /// <summary>
        /// Najlepsze
        /// </summary>
        /// <param name="input">Nazwa parametru jest ok</param>
        /// <returns>Infomacja czy dany łańcuch znaków jest palindromem</returns>
        public bool IsPalindrome(string input)
        {
            var forwards = input.Replace(" ", "");

            var backwards = new string(forwards.Reverse().ToArray());

            return backwards.Equals(forwards);
        }
    }
}
