using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_project.Observer
{
    public class User : IObserver
    {
        public string Password { get; set; }
        public User(string password)
        {

            Password = password;

        }
        public void requestToReview()
        {
            if (Password == "1234")
            {
                Console.WriteLine("review secceeded!!!");
            }
            else
            {
                Console.WriteLine("you have no access to review.");
            }
        }
    }
}
