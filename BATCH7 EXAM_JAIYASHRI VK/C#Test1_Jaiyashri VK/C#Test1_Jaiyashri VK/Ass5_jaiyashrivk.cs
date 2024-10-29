namespace C_Test1_Jaiyashri_VK
{
    internal class Ass5_jaiyashrivk
    {
        static void Main()
        {
            Console.WriteLine("**************** Welcome to My Chocolate Store **********************");
            Console.WriteLine("Please select your chocolate displayed in the menucard:");

            // Total amount initialization
            int totalAmount = 0;
            bool ordering = true;

            // Prices of the chocolates
            int dairyMilkPrice = 50;
            int kitkatPrice = 40;
            int munchPrice = 30;

            while (ordering)
            {
                // Display chocolate options to the customer
                Console.WriteLine("Please choose your favorite chocolate: ");
                Console.WriteLine("1. Dairy Milk");
                Console.WriteLine("2. Kitkat");
                Console.WriteLine("3. Munch");
                Console.Write("Please type your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        totalAmount += dairyMilkPrice;
                        Console.WriteLine("You selected Dairy Milk.");
                        break;
                    case "2":
                        totalAmount += kitkatPrice;
                        Console.WriteLine("You selected Kitkat.");
                        break;
                    case "3":
                        totalAmount += munchPrice;
                        Console.WriteLine("You selected Munch.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        continue; // Restart the loop for valid input       
                }

                // Ask if the customer wants more chocolates
                Console.Write("Do you want more (y/n): ");
                string wantMore = Console.ReadLine().ToLower();

                // Check if the customer wants to continue ordering
                if (wantMore != "y")
                {
                    ordering = false; // Exit the loop
                }
            }

            // Thank the customer and display the total amount
            Console.WriteLine("Thanks for choosing my chocolate:");
            Console.WriteLine($"Your total amount is: Rs {totalAmount}");
            Console.WriteLine("********************************* Payment done ******************************");
        }
    }
}
