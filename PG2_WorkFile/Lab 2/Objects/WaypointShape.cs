using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2
{
    class WaypointShape
    {
        protected Point position;
        public bool isSelected;


        public WaypointShape(Point pos)
        {
            position = pos;
        }

        public Point Position
        {
            get
            {
                return position;
            }
        }

        public virtual void Draw(Graphics Container, bool isSelected)
        {

        }

        public override string ToString()
        {
            return position.ToString();
        }

        public virtual string Type()
        {
            return "";
        }

        public bool isInShape(Point e)
        {
            //e.X >= (shapeList.Items[i] as WaypointShape).Position.X - 12 && e.X <= (shapeList.Items[i] as WaypointShape).Position.X + 12 && e.Y >= (shapeList.Items[i] as WaypointShape).Position.Y - 12 && e.Y <= (shapeList.Items[i] as WaypointShape).Position.Y + 12
            if (e.X >= position.X - 12 && e.X <= position.X + 12 && e.Y >= position.Y - 12 && e.Y <= position.Y + 12)
                return true;
            return false;
        }
    }
}
