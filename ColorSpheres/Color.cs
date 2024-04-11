using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte red;
        
        private byte green;
        
        private byte blue;
        private byte alpha;

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
    }
}