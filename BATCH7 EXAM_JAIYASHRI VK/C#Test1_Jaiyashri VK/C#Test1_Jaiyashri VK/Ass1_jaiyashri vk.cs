namespace C_Test1_Jaiyashri_VK
{
    internal class Program
    {
        static void Main()
        {
            int[] input1 = { 2, 4, 5, 1, 8 };
            int input2 = 5;

            // Check for negative numbers in the array
            bool hasNegative = false;
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] < 0)
                {
                    hasNegative = true;
                
                }
            }
            if (hasNegative)
            {
                Console.WriteLine(-1);
               
            }

            // Check if input2 is negative
            if (input2 < 0)
            {
                Console.WriteLine(-2);
             
            }
            // Sort the array
            Array.Sort(input1);

            // Find the second smallest and second largest
            int secondSmallest = int.MinValue;
            int secondLargest = int.MinValue;
            int uniqueCount = 0;

            // Finding second smallest
            for (int i = 0; i < input1.Length; i++)
            {
                if (i == 0 || input1[i] != input1[i - 1]) // Check for unique
                {
                    uniqueCount++;
                    if (uniqueCount == 2)
                    {
                        secondSmallest = input1[i];
                        break;
                    }
                }
            }

            // Reset uniqueCount for finding second largest
            uniqueCount = 0;

            // Finding second largest
            for (int i = input1.Length - 1; i >= 0; i--)
            {
                if (i == input1.Length - 1 || input1[i] != input1[i + 1]) // Check for unique
                {
                    uniqueCount++;
                    if (uniqueCount == 2)
                    {
                        secondLargest = input1[i];
                        break;
                    }
                }
            } // Check if we found second smallest and largest
            if (secondSmallest == int.MinValue || secondLargest == int.MinValue)
            {
                Console.WriteLine(-1); // Not enough unique elements
            }
            else
            {
                // Calculate the sum
                int result = secondSmallest + secondLargest;
                Console.WriteLine(result);
            }
        }
    }


}