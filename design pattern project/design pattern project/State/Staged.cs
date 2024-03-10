using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public class Staged : IState
    {
        private string _prev;
        public Staged(string prev)
        {

            _prev = prev;

        }
        public void ChangeStatus(Branch branch)
        {
            branch._status = new Committed("Staged");
        }

        public void PrintStatus()
        {
            Console.WriteLine("Staged");
        }
    }
}
