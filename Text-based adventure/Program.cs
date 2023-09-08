using System;

class Program
{
    static void Main()
    {
        // Set the console window size to full screen
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

        // Hide the cursor
        Console.CursorVisible = false;

        // Display a logo or banner
        Console.WriteLine("******************************************");
        Console.WriteLine("*         Welcome to the Choice Game     *");
        Console.WriteLine("*             Enter the Cave             *");
        Console.WriteLine("******************************************");
        Console.WriteLine();
        Console.WriteLine("You find yourself standing in front of a mysterious cave.");
        Console.WriteLine("Do you want to enter the cave? (yes/no)");

        string choice = Console.ReadLine().ToLower();

        if (choice == "yes")
        {
            Console.WriteLine("You enter the cave and see two tunnels.");
            Console.WriteLine("Do you want to go left or right? (left/right)");

            choice = Console.ReadLine().ToLower();

            if (choice == "left")
            {
                Console.WriteLine("You follow the left tunnel and find a treasure chest!");
                Console.WriteLine("Congratulations! You win!");
            }
            else if (choice == "right")
            {
                Console.WriteLine("You follow the right tunnel and encounter a dragon.");
                Console.WriteLine("You were not prepared, and the dragon defeats you. Game over!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over!");
            }
        }
        else if (choice == "no")
        {
            Console.WriteLine("You decide not to enter the cave and leave.");
            Console.WriteLine("The adventure ends here. Thanks for playing!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Game over!");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        // Restore the console window size and cursor visibility when exiting
        Console.SetWindowSize(180, 125); // Set your desired window size here
        Console.CursorVisible = true;
    }
}
