
using System;

namespace MoviesRepresentation
{
    class Actor
    {
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public int Age()
        {
            return DateTime.Now.Year - YearOfBirth;
        }


    }
}
