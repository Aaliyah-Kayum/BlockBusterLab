using System;

namespace BlockBuster
{
    class BlockBuster
    {
        List<Movie> Movies { get; set; } = new List<Movie>();
        public BlockBuster()
        {
            Movies.Add(new DVD("The Lion King", Genre.Animation, "I can't wait to be King", "Mufasa death scene", "Hakuna Matata" "Scar's villain arc"));
            Movies.Add(new DVD("Infinity War", Genre.Action, "Thanos snaps I think", "Infinity stone hunting", "RIP Spider-Man"));
            VHS.Add(new VHS("Poltergeist", Genre.Horror, "Weird stuff happens", "Someone dies probably", "ghosts takeover or smth"));
            VHS.Add(new VHS("Star Wars", Genre.Sci - fi, "Jedi stuff", "Yoda", "I don't remember what else", "Luke, I am your Father"));
        }
        public Movie watchMovies(int list)
        {
            Movies m = Movies[list];
            return m;
        }

        public List<Movie> SearchByGenres(Genre[] SearchForMovie)
        {
            List<Movie> result = new List<Movie>();
            for (int i = 0; i <Movies.Count; i++)
            {
                Movies m = Movies[i];
                if(SearchForMovie.Contains(m.Category))
                {
                    result.Add(m);
                }
            }
            return result;
        }
    }
}