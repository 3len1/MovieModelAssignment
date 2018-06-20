using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesRepresentation
{
    class InitData
    {
        public const string COMMENTS = "Demo comment by the critic";
        public const string CRITIC_1 = "Troll";
        public const string CRITIC_2 = "Trolling";
        public const string CRITIC_3 = "KoyotTeam";
        public const string CRITIC_4 = "Fear";
        public const string CRITIC_5 = "Cancer";


        public static Movie HarryPotterInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Daniel", LastName = "Radcliffe", YearOfBirth = 1989 },
                new Actor { FirstName = "Emma", LastName = "Watson", YearOfBirth = 1990 },
                new Actor { FirstName = "Rupert", LastName = "Grint", YearOfBirth = 1988 },
                new Actor { FirstName = "Tom", LastName = "Felton", YearOfBirth = 1987 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 8, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 7, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 10, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Harry Potter",
                TicketPrice = 7M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie AnnabelleInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Annabelle", LastName = "Walls", YearOfBirth = 1988 },
                new Actor { FirstName = "Ward", LastName = "Horton", YearOfBirth = 1976 },
                new Actor { FirstName = "Brian", LastName = "Howe", YearOfBirth = 1955 },
                new Actor { FirstName = "Kerry", LastName = "O'Malley", YearOfBirth = 1958 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 8, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Annabelle",
                TicketPrice = 8.5M ,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie CoralineInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Dakota", LastName = "Fanning", YearOfBirth = 1994 },
                new Actor { FirstName = "Teri", LastName = "Hatcher", YearOfBirth = 1964 },
                new Actor { FirstName = "Jennifer", LastName = "Saunders", YearOfBirth = 1958 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_4, Rating = 10, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Coralline",
                TicketPrice = 7.5M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie TheRingInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Naomi", LastName = "Watts", YearOfBirth = 1968 },
                new Actor { FirstName = "Daveigh", LastName = "Chase", YearOfBirth = 1990 },
                new Actor { FirstName = "David", LastName = "Dorfman", YearOfBirth = 1993  }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_4, Rating = 10, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "The ring",
                TicketPrice = 6.8M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie TheShapeOfWaterInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Sally", LastName = "Hawkins", YearOfBirth = 1976 },
                new Actor { FirstName = "Doug", LastName = "Jones", YearOfBirth = 1960 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 5, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 6, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 8, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_4, Rating = 10, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "The shape of water",
                TicketPrice = 5.8M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie DeadPool2Init()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Ryan", LastName = "Reynolds", YearOfBirth = 1972 },
                new Actor { FirstName = "Josh", LastName = "Brolin", YearOfBirth = 1968 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 4, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 3, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 5, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 7, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Dead Pool 2",
                TicketPrice = 7M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie TheGrudgeInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Sarah", LastName = "Michelle", YearOfBirth = 1977 },
                new Actor { FirstName = "Yuya", LastName = "Ozeki", YearOfBirth = 1996 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 9, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "The grudge",
                TicketPrice = 7.8M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie TheRoomInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Tommy", LastName = "Wiseau", YearOfBirth = 1955 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 3, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 2, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 3, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "The room",
                TicketPrice = 8M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie NecromentiaInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Chad", LastName = "Grimes", YearOfBirth = 1968 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_4, Rating = 10, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Necromentia",
                TicketPrice = 10M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie TheRuinsInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Laura", LastName = "Ramsey", YearOfBirth = 1982 },
                new Actor { FirstName = "Jena", LastName = "Malone", YearOfBirth = 1984 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 7, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 6, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 8, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_4, Rating = 10, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "The ruins",
                TicketPrice = 6.5M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie StarWarsInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Carrie", LastName = "Fisher", YearOfBirth = 1956 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 8, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 7, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 7, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Star Wars",
                TicketPrice = 7.8M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie LordOfTheRingsInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Orlando", LastName = "Bloom", YearOfBirth = 1977 },
                new Actor { FirstName = "Liv", LastName = "Tyler", YearOfBirth = 1977 },
                new Actor { FirstName = "Elijah", LastName = "Wood", YearOfBirth = 1981 },
                new Actor { FirstName = "Viggo", LastName = "Mortensen", YearOfBirth = 1958 },
                new Actor { FirstName = "Cate", LastName = "Blanchett", YearOfBirth = 1969 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 7, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 6, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 7, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 6, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Lord of the rings",
                TicketPrice = 8M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie TheMessengersInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Kristen", LastName = "Stewart", YearOfBirth = 1990 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 8, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 9, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "The messengers",
                TicketPrice = 7M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie MaryAndMaxInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Philip", LastName = "Seymour", YearOfBirth = 1967 },
                new Actor { FirstName = "Toni", LastName = "Collette", YearOfBirth = 1972 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 10, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 8, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_4, Rating = 10, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Mary and Max",
                TicketPrice = 6.5M,
                Actors = actors,
                Reviews = reviews,
            };
        }

        public static Movie TransformersInit()
        {
            HashSet<Actor> actors = new HashSet<Actor>
            {
                new Actor { FirstName = "Optimus", LastName = "Prime", YearOfBirth = 1988 }
            };
            IList<Review> reviews = new List<Review>
            {
                new Review { CriticName = CRITIC_1, Rating = 5, Comments=COMMENTS},
                new Review { CriticName = CRITIC_2, Rating = 6, Comments=COMMENTS},
                new Review { CriticName = CRITIC_3, Rating = 8, Comments=COMMENTS},
                new Review { CriticName = CRITIC_5, Rating = 9, Comments=COMMENTS},
                new Review { CriticName = CRITIC_4, Rating = 8, Comments=COMMENTS}
            };
            return new Movie
            {
                Tittle = "Transformers",
                TicketPrice = 8M,
                Actors = actors,
                Reviews = reviews,
            };
        }
    }
}
