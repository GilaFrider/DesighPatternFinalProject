using design_pattern_project.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public class Draft:IState
    {


        public void ChangeStatus(MyFile file,User user)
        {
            file._status = new Staged("Draft");
        }

        public void PrintStatus()
        {
            Console.WriteLine("DRAFT");
        }
    }
}
