using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private float radius;
        private int thrown;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.thrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw(){
            if (radius > 0){
                thrown++;
            }
        }

        public int GetTimesThrown(){
            return thrown;
        }
    }
}