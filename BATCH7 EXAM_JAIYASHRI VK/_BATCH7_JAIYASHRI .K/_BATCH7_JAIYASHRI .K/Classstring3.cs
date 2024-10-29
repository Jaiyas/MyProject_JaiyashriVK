using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BATCH7_JAIYASHRI_.K
{
    internal class Classstring3
    {
        public static void Main()
        {
            string nullStr = null;
            string empStr = string.Empty;
            string name = "Mahesh Chand";
         if ((name != nullStr) || (name != empStr))
                 {
                Console.WriteLine(name + " is neither null nor empty");
                }

        }
    }
}
