using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IState
    {
        void CheckOut(User user);
        void Return(User user);
        void PlaceHold(User user);
    }
}
