using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.Momento
{
    public class ConcreteMemento : IMomento
    {
        public MyFile File { get; set; }
        public ConcreteMemento(MyFile file)
        {
            File = file;
        }
        public DateTime GetFileDateTime()
        {
           return DateTime.Now;
        }

        public string GetFileName()
        {
            return File.Name;
        }

        public MyFile GetFileState()
        {
            return File;
        }
    }
}
