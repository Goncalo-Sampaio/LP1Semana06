using System;

namespace BetterColorSpheres
{
    /// <summary>
    /// Class that handles spheres and shows their status to the user
    /// </summary>
    class Program
    {
        /// <summary>
        ///Main method of the program where we instantiate the necessary objects
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Instantiating colors and spheres
            Color red = new Color(255, 0, 0);
            Color cyan = new Color(0, 255, 255);
            Color magenta = new Color(255, 0, 255);

            Sphere sphere1 = new Sphere(red, 5);
            Sphere sphere2 = new Sphere(cyan, 7);
            Sphere sphere3 = new Sphere(magenta, 9);

            //Handling the spheres
            sphere1.Pop();
            sphere2.Throw();
            sphere2.Throw();
            sphere3.Throw();
            sphere3.Pop();
            sphere3.Throw();

            //Printing sphere status to the user
            Console.WriteLine("Sphere 1:");
            Console.WriteLine($"Thrown: {sphere1.Thrown}");
            Color s1Color = sphere1.Color;
            Console.Write($"{s1Color.Red}, ");
            Console.Write($"{s1Color.Green}, ");
            Console.WriteLine($"{s1Color.Blue}");

            Console.WriteLine("Sphere 2:");
            Console.WriteLine($"Thrown: {sphere2.Thrown}");
            Color s2Color = sphere2.Color;
            Console.Write($"{s2Color.Red}, ");
            Console.Write($"{s2Color.Green}, ");
            Console.WriteLine($"{s2Color.Blue}");

            Console.WriteLine("Sphere 3:");
            Console.WriteLine($"Thrown: {sphere3.Thrown}");
            Color s3Color = sphere3.Color;
            Console.Write($"{s3Color.Red}, ");
            Console.Write($"{s3Color.Green}, ");
            Console.WriteLine($"{s3Color.Blue}");
        }
    }
}
