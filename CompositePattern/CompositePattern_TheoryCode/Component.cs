using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_TheoryCode
{
    // The Component
    public class Component<T> : IComponent<T>
    {
        public T Name { get; set; }

        public void Add(IComponent<T> c)
        {
            Console.WriteLine("Cannot add to an item");
        }

        public string Display(int depth)
        {
            return new String('-', depth) + Name + "\n";
        }

        public IComponent<T> Find(T s)
        {
            if (s.Equals(Name))
                return this;
            else
                return null;
        }

        public IComponent<T> Remove(T s)
        {
            throw new NotImplementedException();
        }
    }
}
