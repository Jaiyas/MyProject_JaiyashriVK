using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BATCH7_JAIYASHRI_.K
{
    internal class Classstring6
    {
        public static void Main()
        {
          string name = "Mahesh Chand";
           int age = 33;
         string authorInfo = string.Format("{0} is {1} years old.", name, age.ToString());
           Console.WriteLine(authorInfo);

        }
    }
}
