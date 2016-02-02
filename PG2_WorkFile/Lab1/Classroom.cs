using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Classroom
    {
        ListBox room;

        public Classroom()
        {
            ListBox room = new ListBox();
        }

        public ListBox Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }

        public void AddStudent(Student student)
        {
            room.Items.Add(student);
        }
    }
}
