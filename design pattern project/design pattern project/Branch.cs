using design_pattern_project.Clone;
using design_pattern_project.Observer;
using design_pattern_project.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project
{
    public class Branch : IObject, IClone, IReview
    {
        
        
        private List<IObject> _elements = new List<IObject>();
        private List<IObserver> _observer = new List<IObserver>();
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

        public void requestToReview()
        {
            Console.WriteLine("Are you a collaborator? password--");
            string ans = Console.ReadLine();
            if (ans == "1234")
            {
                Console.WriteLine("review secceeded 👍");
            }
            else
            {
                Console.WriteLine("you have no access to review.");
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
        public void CreateNewBranch()
        {
            Console.WriteLine("create");
        }
        public void Undo()
        {
            Console.WriteLine("undo");
        }

        public Branch CreateCloneBranch(Branch branch)
        {
            Branch cloneBranch = new Branch(Name);
            foreach (var e in _elements)
            {
                cloneBranch.Add(e.clone());
            }
            return cloneBranch;
        }

        public IObject clone()
        {
            return new Branch(Name);
        }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Attach observer");
            _observer.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Detach observer");
            _observer.Remove(observer);

        }

        public void Notify()
        {
            foreach(var o in _observer)
            {
                o.requestToReview();
            }
        }
    }
}
