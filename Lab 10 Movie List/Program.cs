using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>
            {
            new Movie("Toy Story", "Animated"),
            new Movie("The Lion King", "Animated"),
            new Movie("The Departed", "Drama"),
            new Movie("American Beauty", "Drama"),
            new Movie("A Quiet Place", "Horror"),
            new Movie("Halloween", "Horror"),
            new Movie("Scream", "Horror"),
            new Movie("Total Recall", "Sci-Fi"),
            new Movie("Star Wars: A New Hope", "Sci-Fi"),
            new Movie("Inception", "Sci-Fi")
        };

            List<Movie> sortedList = movieList.OrderBy(movieList => movieList.Title).ToList();

            MovieSelection(sortedList);
        }
        static void MovieSelection(List<Movie> movies)
        {
            string continueFlag;
            do
            {
                Console.WriteLine("Enter a movie category:\nAnimated\nDrama\nHorror\nSci-Fi\n");
                var userChoice = Console.ReadLine().ToLower();
                Console.WriteLine();
                foreach (var movie in movies)
                {
                    if (userChoice == movie.Category.ToLower())
                    {
                        Console.WriteLine(movie.Title);
                    }
                    else if (String.IsNullOrEmpty(userChoice))
                    {
                        Console.WriteLine("Enter valid input.");
                        break;
                    }
                }
                Console.WriteLine("\nDo you want to continue? Y/N");
                continueFlag = Console.ReadLine().ToLower();
                Console.WriteLine();
            } while (continueFlag == "y");
            Console.WriteLine("Bye!");


        }
    }
}
