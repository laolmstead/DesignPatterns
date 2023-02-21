using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Order>> _Observers;
        private IObserver<Order> _Observer;

        public Unsubscriber(List<IObserver<Order>> observers, IObserver<Order> observer) 
        {
            _Observers = observers;
            _Observer = observer;
        }

        public void Dispose()
        {
            if (_Observers != null)
                _Observers.Remove(_Observer);
        }
    }
}
