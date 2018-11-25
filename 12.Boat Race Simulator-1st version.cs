using System;
namespace BoatRaceSimulator
{
    class BoatRaceSimulator
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a character for the 1st boat: ");
                char firstBoat = char.Parse(Console.ReadLine());
                Console.Write("Enter a character for the 2nd boat: ");
                char secondBoat = char.Parse(Console.ReadLine());

                //input and check the input for the number of the strings
                Console.Write("Enter number of texts that will be received below (1-20): ");
                int number = int.Parse(Console.ReadLine());
                while (number < 1 || number > 20)
                {
                    Console.Write("Invalid number of texts. It must be between 1 and 20: ");
                    number = int.Parse(Console.ReadLine());
                }

                int firstBoatMovies = 0;
                int secondBoatMovies = 0;

                for (int i = 1; i <= number; i++)
                {
                    //input and check for the length of the given strings
                    Console.Write($"Enter text #{i} (max 100 characters): ");
                    string tiles = Console.ReadLine().ToUpper();
                    while (tiles.Length > 100 || tiles.Length == 0)
                    {
                        Console.Write($"Too long text.It must contain maximum 100 characters.\nEnter again text #{i}: ");
                        tiles = Console.ReadLine().ToUpper();
                    }

                    if (tiles == "UPGRADE")
                    {
                        firstBoat += (char)3;
                        secondBoat += (char)3;
                    }

                    else
                    {
                        if (firstBoatMovies >= 50 || secondBoatMovies >= 50)
                        {
                            break;
                        }

                        if (i % 2 == 1)
                        {
                            firstBoatMovies += tiles.Length;
                        }
                        else if (i % 2 == 0)
                        {
                            secondBoatMovies += tiles.Length;
                        }
                    }
                }

                if (firstBoatMovies >= secondBoatMovies)
                {
                    Console.Write($"The character representation of the winning boat is: ");
                    Console.WriteLine(firstBoat);
                }
                else if (firstBoatMovies < secondBoatMovies)
                {
                    Console.Write($"The character representation of the winning boat is: ");
                    Console.WriteLine(secondBoat);
                }

            }
            catch
            {
                Console.WriteLine("Invalid input! Start from the beginning!");
            }
        }
    }
}