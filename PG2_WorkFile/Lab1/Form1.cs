using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        //Classroom[] rooms;

        public Form1()
        {
            InitializeComponent();
            //rooms = new Classroom[3];
            //for (int i = 0; i < rooms.Length; i++)
            //{
            //    rooms[i] = new Classroom();
            //}
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            int classRoom = (int)classroomCount.Value;
            Student tempStudent = new Student(firstNameBox.Text, lastNameBox.Text);
            firstNameBox.Clear();
            lastNameBox.Clear();
            classroomCount.ResetText();

            // rooms[classRoom - 1].AddStudent(tempStudent);

            //classList1 = rooms[1].Room;
            //classList2 = rooms[2].Room;
            //classList3 = rooms[3].Room;

            switch (classRoom)
            {
                case 1:
                    classList1.Items.Add(tempStudent);
                    break;
                case 2:
                    classList2.Items.Add(tempStudent);
                    break;
                case 3:
                    classList3.Items.Add(tempStudent);
                    break;
            }
        }
    }
}
