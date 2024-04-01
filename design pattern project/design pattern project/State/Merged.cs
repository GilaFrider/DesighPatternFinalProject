using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public class Merged : IState
    {
        private string _prev;
        public Merged(string prev)
        {
            _prev = prev;
        }
        public void ChangeStatus(MyFile file)
        {
            Console.WriteLine("Merged already.");
        }

        public void PrintStatus()
        {
            Console.WriteLine("Merged");
        }
    }
}
