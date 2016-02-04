using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2.Objects
{
    class Circle : WaypointShape
    {
        public Circle(Point pos) : base(pos)
        {

        }
        public override void Draw(Graphics Container, bool isSelected)
        {
            Rectangle rect = new Rectangle(new Point(position.X - 12, position.Y - 12), new Size(25, 25));
            if (isSelected)
            {
                Pen myPen = new Pen(Color.Red);
                Container.DrawEllipse(myPen, rect);
            }
            else
            {
                Pen myPen = new Pen(Color.Black);
                Container.DrawEllipse(myPen, rect);
            }
        }

        public override string Type()
        {
            return "Circle";
        }
    }
}
