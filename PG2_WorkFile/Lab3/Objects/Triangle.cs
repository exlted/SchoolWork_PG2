using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Objects
{
    class Triangle : IShape
    {
        int Base;
        int Height;

        public Triangle(int _base, int _height)
        {
            Base = _base;
            Height = _height;
        }

        public float getArea()
        {
            return ((Base * Height) / 2);
        }
    }
}
