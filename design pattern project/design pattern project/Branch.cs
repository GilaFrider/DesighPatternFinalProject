using design_pattern_project.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project
{
    public class Branch : IObject
    {
        public IState _status { get; set; }
        
        private List<IObject> _element = new List<IObject>();
        public Branch()
        {
            _status = new Draft();
        }
        public void Add(IObject c)
        {
            _element.Add(c);
        }

        public void Remove(IObject e)
        {
            _element.Remove(e);
        }

        public void print()
        {

            Console.WriteLine("Branch");
            foreach (var e in _element)
            {
                e.print();
            }
        }
    }
}
