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
        
        
        private List<IObject> _elements = new List<IObject>();

        public void Add(IObject e)
        {
            _elements.Add(e);
        }

        public void Remove(IObject e)
        {
            _elements.Remove(e);
        }

        public void print()
        {

            Console.WriteLine("Branch");
<<<<<<< HEAD
            
=======
>>>>>>> dcbae56da6bba50a9f66dd28cc0a1cce674b3486

            foreach (var e in _elements)
            {
                e.print();
            }
        }


        public void Merge()
        {
            Console.WriteLine("merge");
        }
        public void Commit()
        {
            Console.WriteLine("commit");
        }
        public void Delete()
        {
            Console.WriteLine("delete");
        }
        public void Create()
        {
            Console.WriteLine("create");
        }
        public void Undo()
        {
            Console.WriteLine("undo");
        }
    }
}
