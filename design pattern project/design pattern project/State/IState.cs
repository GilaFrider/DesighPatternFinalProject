using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public interface IState
    {
        public void ChangeStatus(MyFile file);
        public void PrintStatus();
    }
}
