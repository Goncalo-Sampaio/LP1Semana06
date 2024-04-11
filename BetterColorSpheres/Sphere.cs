using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color{get;}
        public float Radius{get; private set;}
        public int Thrown{get; set;}

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            Thrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw(){
            if (Radius > 0){
                Thrown++;
            }
        }
    }
}