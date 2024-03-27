using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using design_pattern_project.State;

namespace design_pattern_project
{
    public class MyFile :IObject
    {
        public IState _status { get; set; }
        public MyFile()
        {
            _status = new Draft();
        }
        public void print()
        {
            Console.WriteLine("file");
        }
    }
}
