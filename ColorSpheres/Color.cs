using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte red;
        
        private readonly byte green;
        
        private readonly byte blue;
        private readonly byte alpha;

        public Color(byte red, byte green, byte blue){
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public byte GetGrey(){
            int value = (red + green + blue) / 3;
            return (byte)value;
        }

        public byte GetBlue(){
            return blue;
        }

        public byte GetGreen(){
            return green;
        }

        public byte GetRed(){
            return red;
        }

        public byte GetAlpha(){
            return alpha;
        }
    }
}