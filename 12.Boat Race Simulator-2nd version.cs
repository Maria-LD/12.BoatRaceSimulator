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
                String firstBoat = Console.ReadLine().ToLower();
                while (firstBoat.Length > 1 ||
                    "0".Equals(firstBoat) || "1".Equals(firstBoat) ||
                    "2".Equals(firstBoat) || "3".Equals(firstBoat) || "4".Equals(firstBoat) ||
                    "5".Equals(firstBoat) || "6".Equals(firstBoat) || "7".Equals(firstBoat) ||
                    "8".Equals(firstBoat) || "9".Equals(firstBoat) ||
                    "a".Equals(firstBoat) || "b".Equals(firstBoat) || "c".Equals(firstBoat) ||
                    "d".Equals(firstBoat) || "e".Equals(firstBoat) || "f".Equals(firstBoat) ||
                    "g".Equals(firstBoat) || "h".Equals(firstBoat) || "i".Equals(firstBoat) ||
                    "j".Equals(firstBoat) || "k".Equals(firstBoat) || "l".Equals(firstBoat) ||
                    "m".Equals(firstBoat) || "n".Equals(firstBoat) || "o".Equals(firstBoat) ||
                    "p".Equals(firstBoat) || "q".Equals(firstBoat) || "r".Equals(firstBoat) ||
                    "s".Equals(firstBoat) || "t".Equals(firstBoat) || "u".Equals(firstBoat) ||
                    "v".Equals(firstBoat) || "w".Equals(firstBoat) || "x".Equals(firstBoat) ||
                    "y".Equals(firstBoat) || "z".Equals(firstBoat))
                {
                    Console.WriteLine("Invalid inpit. Try againg - character cant be a letter or number: ");
                    firstBoat = Console.ReadLine().ToLower();
                }

                Console.Write("Enter a character for the 2nd boat: ");
                String secondBoat = Console.ReadLine().ToLower();
                while (secondBoat.Length > 1 ||
                    "0".Equals(secondBoat) || "1".Equals(secondBoat) ||
                    "2".Equals(secondBoat) || "3".Equals(secondBoat) || "4".Equals(secondBoat) ||
                    "5".Equals(secondBoat) || "6".Equals(secondBoat) || "7".Equals(secondBoat) ||
                    "8".Equals(secondBoat) || "9".Equals(secondBoat) ||
                    "a".Equals(secondBoat) || "b".Equals(secondBoat) || "c".Equals(secondBoat) ||
                    "d".Equals(secondBoat) || "e".Equals(secondBoat) || "f".Equals(secondBoat) ||
                    "g".Equals(secondBoat) || "h".Equals(secondBoat) || "i".Equals(secondBoat) ||
                    "j".Equals(secondBoat) || "k".Equals(secondBoat) || "l".Equals(secondBoat) ||
                    "m".Equals(secondBoat) || "n".Equals(secondBoat) || "o".Equals(secondBoat) ||
                    "p".Equals(secondBoat) || "q".Equals(secondBoat) || "r".Equals(secondBoat) ||
                    "s".Equals(secondBoat) || "t".Equals(secondBoat) || "u".Equals(secondBoat) ||
                    "v".Equals(secondBoat) || "w".Equals(secondBoat) || "x".Equals(secondBoat) ||
                    "y".Equals(secondBoat) || "z".Equals(secondBoat))
                {
                    Console.WriteLine("Invalid inpit. Try againg - character cant be a letter or number: ");
                    secondBoat = Console.ReadLine().ToLower();
                }

                Console.Write("Enter number of texts that will be received below (1-20): ");
                int number = int.Parse(Console.ReadLine());
                while (number < 1 || number > 20)
                {
                    Console.Write("Invalid number of texts. It must be between 1 and 20: ");
                    number = int.Parse(Console.ReadLine());
                }

                int firstBoatMovies = 0;
                int secondBoatMovies = 0;
                char firstBoatChar = firstBoat[0];
                char secondBoatChar = secondBoat[0];

                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"Enter text #{i} (max 100 characters): ");
                    string tiles = Console.ReadLine().ToUpper();
                    while (tiles.Length > 100 || tiles.Length == 0)
                    {
                        Console.Write($"Too long text.It must contain maximum 100 characters.\nEnter again text #{i}: ");
                        tiles = Console.ReadLine().ToUpper();
                    }

                    if (tiles == "UPGRADE")
                    {
                        firstBoatChar += (char)3;
                        secondBoatChar += (char)3;
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
                    Console.WriteLine(firstBoatChar);
                }
                else if (firstBoatMovies < secondBoatMovies)
                {
                    Console.Write($"The character representation of the winning boat is: ");
                    Console.WriteLine(secondBoatChar);
                }

            }
            catch
            {
                Console.WriteLine("Invalid input! Start from the beginning!");
            }
        }
    }
}