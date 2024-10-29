using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BATCH7_JAIYASHRI_.K
{
    internal class Classstring5
    {
        public static void Main()
        {
             string name = "Mahesh Chand";
         Console.WriteLine("Size of string: {0}", name.Length);
          string nameWithoutEmptyChar = name.Replace(" ", "");
         Console.WriteLine("Size of non empty char string: {0}", nameWithoutEmptyChar.Length);
          for (int counter = 0; counter <= nameWithoutEmptyChar.Length - 1; counter++)
         Console.WriteLine(nameWithoutEmptyChar[counter]);


        }
    }
}
