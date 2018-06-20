using System;
using System.Collections.Generic;

namespace MoviesRepresentation
{
    class Program
    {
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Movie> movies = new List<Movie>
            {
                InitData.HarryPotterInit(),
                InitData.AnnabelleInit(),
                InitData.CoralineInit(),
                InitData.DeadPool2Init(),
                InitData.LordOfTheRingsInit(),
                InitData.MaryAndMaxInit(),
                InitData.NecromentiaInit(),
                InitData.StarWarsInit(),
                InitData.TheGrudgeInit(),
                InitData.TheMessengersInit(),
                InitData.TheRingInit(),
                InitData.TheRoomInit(),
                InitData.TheRuinsInit(),
                InitData.TheShapeOfWaterInit(),
                InitData.TransformersInit()
            };
            
            foreach(Movie movie in movies)
            {
                movie.SoldOut(GetRandomNumber(1,10));
                movie.SoldOut(GetRandomNumber(1,5));
                movie.CalculateRating();
                Console.WriteLine(movie.Tittle + " sold " + movie.Tickets + " and total income is " + movie.CalculateIncome());
            }

            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
            movies.Sort((m,n) => m.Rating.CompareTo(n.Rating));
            movies.Reverse();

            foreach (Movie m in movies.GetRange(0,10))
            {
                Console.WriteLine(m.Tittle + " -- " + m.Rating);
            }

            Console.ReadLine();
        }
    }
}
