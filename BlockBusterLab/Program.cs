using System;
using System.Collections.Generic;
namespace BlockBusterLab
{
    class Program
    { 
        static void Main()
        {
            //print
           
            Movie m = new Movie("The Lion King", Genre.Animation, 1200, "Just can't wait to be king", "Mufasa dies", "Hakuna Matata");
            m.PrintInfo();

            foreach(Movie result in m)
            {
                Console.WriteLine(result);
            }
            
        }
    }
}
