using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Objects
{
    class Circle : IShape
    {
        int radius;

        public Circle(int Radius)
        {
            radius = Radius;
        }

        public float getArea()
        {
            return (float)(Math.PI * (radius ^ 2));
        }
    }
}
