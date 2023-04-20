using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class ComputerList<T> : IEnumerable<T> where T : IComputer
    {
        private List<T> _List = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in _List)
            {
                yield return t;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T t)
        {
            _List.Add(t);
        }

        public IEnumerable<T> HighestRated
        {
            get
            {
                List<T> list = new List<T>(_List);

                list.Sort((l, r) =>
                {
                    return r.Rating.CompareTo(l.Rating);
                });

                foreach (T t in list)
                    yield return t;
            }
        }

        public IEnumerable<T> Cheapest
        {
            get
            {
                List<T> list = new List<T>(_List);

                list.Sort((l, r) =>
                {
                    return l.Price.CompareTo(r.Price);
                });

                foreach (T t in list)
                    yield return t;
            }
        }
    }
}
