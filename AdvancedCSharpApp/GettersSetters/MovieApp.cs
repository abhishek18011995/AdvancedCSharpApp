using System;

namespace AdvancedCSharpApp.GettersSetters
{
    class MovieCl
    {
        private int movieRating;

        public MovieCl(string name, int rating)
        {
            MovieName = name;
            MovieRating = rating;
        }

        public string MovieName { get; set; } = "Iron man";

        public int MovieRating
        {
            get => movieRating;
            set  {
                if (value > 0 && value < 11)
                {
                    movieRating = value;
                }
                else
                {
                    movieRating = 0;
                }
            }
        }
    }
    
    class MovieApp
    {
        static void Main()
        {
            MovieCl mc1 = new MovieCl("Avengers Endgame", 9);
            MovieCl mc2 = new MovieCl("ABCD2", 11);
            Console.WriteLine(mc1.MovieRating);
            Console.WriteLine(mc2.MovieRating);
            mc2.MovieRating = 6;
            Console.WriteLine(mc2.MovieRating);
            Console.ReadKey();
        }
    }
}
