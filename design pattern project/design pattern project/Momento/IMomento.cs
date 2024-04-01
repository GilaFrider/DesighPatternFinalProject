using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.Momento
{
    public interface IMomento
    {
        public string GetFileName();

        public MyFile GetFile();
        public DateTime GetFileDateTime();
    }
}
