using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.Clone
{
    public interface IClone
    {
        public Branch CreateCloneBranch(Branch branch);
    }
}
