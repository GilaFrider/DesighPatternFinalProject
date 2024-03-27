using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using design_pattern_project.Momento;
using design_pattern_project.State;

namespace design_pattern_project
{
    public class MyFile :IObject
    {
        public string Name { get; set; }
        public IState _status { get; set; }
        private Stack<IMomento> history  = new Stack<IMomento>();
        public MyFile(string name)
        {
            this.Name = name;
            this._status = new Draft();
        }
        public  IMomento SaveHistory()
        {
            IMomento result = new ConcreteMemento(this);
            history.Push(result);
            return result;
        }
        public void print()
        {
            Console.WriteLine("file");
        }
      
    }
}
