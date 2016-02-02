using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class School
    {
        Classroom[] rooms;

        public School()
        {
            rooms = new Classroom[3];
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Classroom();
            }
        }

        public Classroom GetRoom(int index)
        {
            return rooms[index];
        }


    }
}
