using System;
using System.Linq;

namespace MoviesRepresentation
{
    class Review
    {
        public string CriticName { get; set; }
        //Rating setter can be private but i am lazy to use TestRating in InitData
        public int Rating { get; set; }
        public string Comments { get; set; }
        
        public bool TestRating(int givenRating)
        {
            if (givenRating >=1 && givenRating <=10 )
            {
                Rating = givenRating;
                return true;
            }
            throw new Exception("Rating must be between 1 and 10");
        }
    }
}
