using design_pattern_project.Clone;
using design_pattern_project.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project
{
    public class Branch : IObject,IClone
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
            return new Branch(branch.Name);
        }
    }
}
