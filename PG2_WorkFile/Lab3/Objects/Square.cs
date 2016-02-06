using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Objects
{
    class Square : IShape
    {
        int width;
        int height;

        public Square(int Width, int Height)
        {
            width = Width;
            height = Height;
        }

        public float getArea()
        {
            return width * height;
        }
    }
}
