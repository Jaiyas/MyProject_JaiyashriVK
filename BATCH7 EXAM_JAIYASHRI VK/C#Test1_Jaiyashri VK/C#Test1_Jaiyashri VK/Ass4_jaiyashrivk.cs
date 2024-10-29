namespace C_Test1_Jaiyashri_VK
{
    internal class Ass4_jaiyashrivk
    {
        static void Main()
        {
            int[] inputArray = { 1, 2, 2, 3, 3 };
            int targetValue = 2;

            int count = 0;
            foreach (var item in inputArray)
            {
                if (item == targetValue)
                {
                    count++;
                }
            }
            count = 0;

            // Loop through the array and count occurrences
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == targetValue)
                {
                    count++;
                }
            }

            // Print the result
            Console.WriteLine($"The number {targetValue} appears {count} times in the array.");
        }
    }
}
