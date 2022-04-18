public class Program
{
    public static void Main(string[] args)
    {
        do

        {

            string[] students = { "Jim", "Izzy", "Stefan" };
            string[] hometown = { "Shelby TWP", "Waterford", "Columbus" };
            string[] favoriteFood = { "Hot Dogs", "Pizza", "Cajun fries" };

            Console.WriteLine("Today we have three students, enter a number (1-3) to learn more about them.");
            int userInput = int.Parse(Console.ReadLine());
            string name = students[userInput - 1];
            string home = hometown[userInput - 1];
            string food = favoriteFood[userInput - 1];
            Console.WriteLine($"What would you like to learn about {name}? I can either tell you their hometown or their favorite food.");
            string userChoice = Console.ReadLine().ToLower().Trim();

            if (userChoice == "hometown")
            {
                Console.WriteLine($"{name}'s hometown is {home}.");
            }
            if (userChoice == "favorite food" || userChoice == "food")
            {
                Console.WriteLine($"{name}'s favorite food is {food}");
            }

            string userchoice;
            {
                Console.WriteLine("Would you like to know about another student? Type y or n");
            }
            string Input = Console.ReadLine().ToLower();

            //1) y: move to the next of the loop
            //2) n: stop the loop 

            bool keepRunning = true;
            if (Input == "y")
            {
                keepRunning = true;

            }
            else if (Input == "n")
            {
                Console.WriteLine("Goodbye");

                break;
            }
        } while (true);


    }
}
