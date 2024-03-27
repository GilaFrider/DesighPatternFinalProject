using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public class ReadyToMerge : IState
    {
        private string _prev;
        public ReadyToMerge(string prev)
        {
            _prev = prev;
        }
        public void ChangeStatus(MyFile file)
        {
            file._status = new Merged("ReadyToMerge");
        }

        public void PrintStatus()
        {
            Console.WriteLine("ReadyToMerge");
        }
    }
}
