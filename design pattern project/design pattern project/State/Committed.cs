﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.State
{
    public class Committed : IState
    {
        private string _prev;
        public Committed(string prev)
        {

            _prev = prev;

        }
        public void ChangeStatus(MyFile file)
        {
            file._status = new UnderReview("Committed");
            file.SaveHistory();
        }

        public void PrintStatus()
        {
            Console.WriteLine("Committed");
        }
    }
}
