using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project
{
    public class Folder : IObject
    {
        private List<IObject> _elements = new List<IObject>();
        public string Name { get; set; }
        public Folder(string name)
        {
            Name = name;
        }
        public void Add(IObject e)
        {
            if(e.GetType() == typeof(Branch))
            {
                throw new Exception("Can't add branch to folder");
            }
  
            else _elements.Add(e);
        }

        public void Remove(IObject e)
        {
            _elements.Remove(e);
        }
        public void print()
        {
            Console.WriteLine("folder");
            foreach (var e in _elements)
            {
                e.print();
            }
        }

        public IObject clone()
        {
            Folder cloneFolder = new Folder(Name);
            foreach (var e in _elements)
            {
                cloneFolder.Add(e.clone());
            }
            return cloneFolder;
        }
    }
}
