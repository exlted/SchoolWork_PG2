using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            shapeList.SelectedIndex = 0;
        }

        private void dbp1_MouseClick(object sender, MouseEventArgs e)
        {
            bool test = true;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                try
                {
                    if((listBox1.Items[i] as WaypointShape).isInShape(e.Location))
                    {
                        for (int j = 0; j < listBox1.Items.Count; j++)
                        {
                            (listBox1.Items[i] as WaypointShape).isSelected = false;
                        }
                        (listBox1.Items[i] as WaypointShape).isSelected = true;
                        test = false;
                    }
                }
                catch (Exception)
                {
                }
            }
            if(test)
            {
                if (shapeList.SelectedIndex == 0)
                {
                    listBox1.Items.Add(new Objects.Circle(e.Location));
                }
                else if (shapeList.SelectedIndex == 1)
                {
                    listBox1.Items.Add(new Objects.Square(e.Location));
                }
            }
            dbp1.Invalidate();
        }

        private void dbp1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                switch((listBox1.Items[i] as WaypointShape).Type())
                {
                    case "Square":
                        (listBox1.Items[i] as Objects.Square).Draw(e.Graphics, (listBox1.Items[i] as WaypointShape).isSelected);
                        break;
                    case "Circle":
                        (listBox1.Items[i] as Objects.Circle).Draw(e.Graphics, (listBox1.Items[i] as WaypointShape).isSelected);
                        break;
                }
                if (i > 0)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black), (listBox1.Items[i] as WaypointShape).Position, (listBox1.Items[i - 1] as WaypointShape).Position);
                }
            }
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                (listBox1.Items[i] as WaypointShape).isSelected = false;
            }
            dbp1.Invalidate();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if((listBox1.Items[i] as WaypointShape).isSelected)
                {
                    listBox1.Items.Remove(listBox1.Items[i]);
                }
            }
            dbp1.Invalidate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (listBox1.SelectedItem as WaypointShape).isSelected = true;
                dbp1.Invalidate();
            }
            catch(Exception)
            {
            }
        }
    }
}
