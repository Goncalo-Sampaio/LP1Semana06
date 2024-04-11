using System;

namespace ColorSpheres
{
    class Program
    {
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
            Console.WriteLine($"Thrown: {sphere1.GetTimesThrown()}");
            Color s1Color = sphere1.GetColor();
            Console.Write($"{s1Color.GetRed()}, ");
            Console.Write($"{s1Color.GetGreen()}, ");
            Console.WriteLine($"{s1Color.GetBlue()}");

            Console.WriteLine("Sphere 2:");
            Console.WriteLine($"Thrown: {sphere2.GetTimesThrown()}");
            Color s2Color = sphere2.GetColor();
            Console.Write($"{s2Color.GetRed()}, ");
            Console.Write($"{s2Color.GetGreen()}, ");
            Console.WriteLine($"{s2Color.GetBlue()}");

            Console.WriteLine("Sphere 3:");
            Console.WriteLine($"Thrown: {sphere3.GetTimesThrown()}");
            Color s3Color = sphere3.GetColor();
            Console.Write($"{s3Color.GetRed()}, ");
            Console.Write($"{s3Color.GetGreen()}, ");
            Console.WriteLine($"{s3Color.GetBlue()}");
        }
    }
}
