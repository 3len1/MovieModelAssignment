using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesRepresentation
{
    class Movie
    {
        public string Tittle { get; set; }
        public decimal TicketPrice { get; set; }
        public int Tickets { get; private set; }
        public decimal Rating { get; private set; }
        public decimal Income { get; private set; }
        public HashSet<Actor> Actors { get; set; }
        public IList<Review> Reviews { get; set; }

        public int SoldOut(int number)
        {
            return Tickets += number;
        }

        
        public decimal CalculateIncome()
        {
            Income = this.Tickets * this.TicketPrice;
            return Income;
        }



        public string CalculateRating()
        {
            double average = Reviews.Select(x => x.Rating).Average();
            if(Math.Floor(average) >= 1 && Math.Floor(average) <=10)
            {
                Rating = (decimal) average ;
                return Rating.ToString("0.#");
            }
            throw new Exception("Rating must be between 1 and 10");
        }
    }
}
