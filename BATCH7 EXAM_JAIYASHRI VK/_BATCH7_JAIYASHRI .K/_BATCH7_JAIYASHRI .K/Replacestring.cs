using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BATCH7_JAIYASHRI_.K
{
    using System;

    namespace ReplaceStringApp
    {
        internal class ReplaceString
        {
            public static void Main(string[] args)
            {
                // Accept input from the user
                Console.WriteLine("Enter the input string:");
                string input1 = Console.ReadLine();

                Console.WriteLine("Enter the position of the word (integer):");

                // Validate if the input for the word position is a positive integer
                if (!int.TryParse(Console.ReadLine(), out int input2) || input2 <= 0)
                {
                    Console.WriteLine("Number not positive");
                    return;
                }

                Console.WriteLine("Enter the special character:");
                char input3 = Console.ReadLine()[0];

                // Call the ReplaceString method from UserProgramCode and get the result
                string result = UserProgramCode.ReplaceString(input1, input2, input3);

                // Display the result based on the return value
                if (result == "-1")
                    Console.WriteLine("Invalid String");
                else if (result == "-2")
                    Console.WriteLine("Number not positive");
                else if (result == "-3")
                    Console.WriteLine("Character not a special character");
                else
                    Console.WriteLine(result);
            }
        }

        public class UserProgramCode
        {
            // Method to replace characters in the nth word of the input string
            public static string ReplacestringApp(string str, int n, char specialChar)
            {
                // Rule 1: Check for special characters in the input string
                foreach (char c in str)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                        return "-1";
                }

                // Rule 2: Check if the character is a special character (not a letter or digit)
                if (char.IsLetterOrDigit(specialChar))
                    return "-3";

                // Convert input string to lowercase
                str = str.ToLower();

                // Split the string into words
                string[] words = str.Split(' ');

                // Check if the specified word number exists in the array
                if (n > words.Length)
                    return str;

                // Replace the nth word with the special character repeated for 

            }
        }
    }
