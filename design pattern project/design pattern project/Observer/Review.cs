using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.Observer
{
    public class Review : IObserver
    {
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
    }
}
