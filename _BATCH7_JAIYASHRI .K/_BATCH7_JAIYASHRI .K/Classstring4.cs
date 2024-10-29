using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BATCH7_JAIYASHRI_.K
{
    internal class Classstring4
    {
        public static void Main()
        {
          string sentence = "Mahesh Chand is an author and founder of C# Corner";
          char[] charArr = sentence.ToCharArray();
           foreach (char ch in charArr)
            {
            Console.WriteLine(ch);
             }

        }
    }
}
