using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
    class Notebook
    {
        private List<string> data = new List<string>();

        public void Write(string line)
        {
            data.Add(line);
        }
    }
}
