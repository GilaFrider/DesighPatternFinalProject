using design_pattern_project.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public class Committed : IState
    {
        private string _prev;
        public Committed(string prev)
        {

            _prev = prev;

        }
        public void ChangeStatus(MyFile file,User user)
        {
            file._status = new UnderReview("Committed");
            file.SaveHistory();
            file.Attach(user);
        }

        public void PrintStatus()
        {
            Console.WriteLine("Committed");
        }
    }
}
