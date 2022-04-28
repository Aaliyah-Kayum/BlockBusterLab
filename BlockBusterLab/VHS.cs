using System;

namespace BlockBusterLab
{
    class VHS : Movie
    {
        public int time { get; set; }   = 0;
        public VHS(string Title, Genre Category, int RunTime, string Scenes)
            : base(Title, Category, RunTime, Scenes)

            public void Rewind()
        {
            Console.WriteLine("Now Rewinding");
            time = 0;
        }
    }
}