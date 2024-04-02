using design_pattern_project.Observer;
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
        public void ChangeStatus(MyFile file,User user)
        {
            file._status = new Committed("Staged");
        }

        public void PrintStatus()
        {
            Console.WriteLine("Staged");
        }
    }
}
