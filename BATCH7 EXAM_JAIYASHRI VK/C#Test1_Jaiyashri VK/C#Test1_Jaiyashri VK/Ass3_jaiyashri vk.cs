namespace C_Test1_Jaiyashri_VK
{
    internal class  Ass3_jaiyashri_vk
    {
        static void Main()
        {
                int[] arr = { 1, 2, 2, 3, 4, 4, 5, 5 };
                int[] uniqueArr = new int[arr.Length];
                int uniqueCount = 0;
               // to store the element in the array
                for (int i = 0; i < arr.Length; i++)
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < uniqueCount; j++)
                    {
                        if (arr[i] == uniqueArr[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate)
                    {
                        uniqueArr[uniqueCount] = arr[i];
                        uniqueCount++;
                    }
                }

                // Sort the unique elements in descending order
                Array.Sort(uniqueArr, 0, uniqueCount);
                Array.Reverse(uniqueArr, 0, uniqueCount);

            // Calculate the average of the largest 3 numbers
            double average = (uniqueArr[0] + uniqueArr[1] + uniqueArr[2]);

                // Output the result
                Console.WriteLine("Average of the largest 3 numbers: " + average);
            }
        }
    }
