using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public class UnderReview : IState
    {
        private string _prev;
        public UnderReview(string prev)
        {
            _prev = prev;
        }
        public void ChangeStatus(Branch branch)
        {
            branch._status = new ReadyToMerge("UnderReview");
        }

        public void PrintStatus()
        {
            Console.WriteLine("Under Review");
        }
    }
}
