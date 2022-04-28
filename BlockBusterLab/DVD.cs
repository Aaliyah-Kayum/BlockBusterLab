using System;

namespace BlockBusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, string Scenes)
            : base(Title, Category, RunTime, Scenes)
    }

    public static void Play()
    {
        PrintScenes();
        Console.WriteLine("Is there a scene you'd like to skip to?");
        int scene = int.Parse(Console.ReadLing());
        string movieScene = Scenes[scene;
            Console.WriteLine(scene);
    }
}
