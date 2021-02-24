using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
    class Room
    {
        List<IListener> listeners = new List<IListener>();
        string sound;
        public void Enter(IListener listener)
        {
            listeners.Add(listener);
            Console.WriteLine("Someone entered room!");
        }
        public void Exit(IListener listener)
        {
            if (listeners.Remove(listener))
                Console.WriteLine("Someone exited room!");
        }
        public void Say(string sound)
        {
            this.sound = sound;
            Console.WriteLine(sound);
            foreach(var listener in listeners)
            {
                listener.Listen(sound);
            }
        }
    }
}
