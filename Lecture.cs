using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
    class Lecture
    {
        public static void Main()
        {
            var room = new Room();
            var instructor = new Instructor();
            var num_students = 10;

            for (int i = 0; i < num_students; i++)
            {
                room.Enter(new Student());
            }
            room.Enter(instructor);

            instructor.Say("Starting lecture!", room);
            instructor.Say("Very very useful lecture!", room);
            instructor.Say("Finishing lecture!", room);
            Console.ReadLine();
        }
    }
}
