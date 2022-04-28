using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbBusterLab
{
    class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes = new List<string>();
        public Movie(string Title, genre Category, int RunTime, string[] Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public static void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("RunTime: " + RunTime);
        }
        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{Scenes[i]}");
            }
        }
        public void Play()
        {
            Console.WriteLine("What scene from the movie would you like to watch?");
            if (RunTime < Scenes.Count)
            {
                string scene = Scenes[RunTime];
                RunTime++;
                Console.WriteLine(scene)
            }
            
        }
    }
}