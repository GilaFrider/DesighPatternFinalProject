using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using design_pattern_project.Momento;
using design_pattern_project.Observer;
using design_pattern_project.State;

namespace design_pattern_project
{
    public class MyFile :IObject,IReview
    {
        public string Name { get; set; }
        public IState _status { get; set; }
        private Stack<IMomento> history  = new Stack<IMomento>();
        private List<IObserver> _observer = new List<IObserver>();
        public MyFile(string name)
        {
            Name = name;
            _status = new Draft();
        }
        public  IMomento SaveHistory()
        {
            IMomento result = new ConcreteMemento(this);
            history.Push(result);
            return result;
        }
        
        public void print()
        {
            Console.WriteLine("file");
        }
        public void Undo()
        {
            if (history.Count == 0)
            {
                return;
            }

            var memento = history.Last();
            history.Pop();

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetFileName());
        }
        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var h in history)
            {
                Console.WriteLine(h.GetFileName());
            }
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
            foreach (var o in _observer)
            {
                o.requestToReview();
            }
        }

        public IObject clone()
        {
            return new MyFile(Name);
        }
    }
}
