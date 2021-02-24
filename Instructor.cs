using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
    class Instructor : IListener
    {
        public void Listen(string sound)
        {
            Console.WriteLine("Instructor: I heard " + sound);
        }

        public void Say(string sound, Room room)
        {
            room.Say(sound);
        }
    }
}
