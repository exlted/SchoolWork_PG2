using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2.Objects
{
    class Square : WaypointShape
    {
        public Square( Point pos ) : base(pos)
        {

        }

        public override void Draw(Graphics Container, bool isSelected)
        {
            Rectangle rect = new Rectangle(new Point(position.X - 12, position.Y - 12), new Size(25, 25));
            if (isSelected)
            {
                Pen myPen = new Pen(Color.Red);
                Container.DrawRectangle(myPen, rect);
                myPen.Dispose();
            }
            else
            {
                Pen myPen = new Pen(Color.Black);
                Container.DrawRectangle(myPen, rect);
                myPen.Dispose();
            }
        }

        public override string Type()
        {
            return "Square";
        }
    }
}
