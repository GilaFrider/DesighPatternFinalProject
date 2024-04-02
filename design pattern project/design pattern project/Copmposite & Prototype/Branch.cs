
using design_pattern_project.Observer;
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
        
        public string Name { get; set; }
        public Branch(string name)
        {
            Name = name;
            
        }

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


            foreach (var e in _elements)
            {
                e.print();
            }
        }
        public string Merge()
        {
            Console.WriteLine("merge");
            return "merge";
        }
        public string Commit()
        {
            Console.WriteLine("commit");
            return "commited";
        }
        public string Delete()
        {
            Console.WriteLine("delete");
            return "delete";
        }
        public string CreateNewBranch()
        {
            Console.WriteLine("create");
            return "create";
        }
        public Branch CreateCloneBranch(Branch branch)
        {
            return (Branch) branch.clone();
        }
        public string Undo()
        {
            Console.WriteLine("undo");
            return "undo";
        }


        public IObject clone()
        {
            Branch cloneBranch = new Branch(Name);
            foreach (var e in _elements)
            {
                cloneBranch.Add(e.clone());
            }
            return cloneBranch;
        }

        
    }
}
