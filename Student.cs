using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
    class Student : IListener
    {
        Notebook notebook = new Notebook();
        void IListener.Listen(string sound)
        {
            Console.WriteLine("Student: I heard " + sound);
            Write(sound);
        }

        private void Write(string sound)
        {
            notebook.Write(sound);
        }
    }
}
