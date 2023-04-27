using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Book
    {
        public Book()
        {
            Available = new AvailableState(this);
            CheckedOut = new CheckedOutState(this);

            State = Available;
            HoldList = new Queue<User>();
        }

        public string? Name { get; set; }
        public User? CurrentUser { get; set; }
        public Queue<User> HoldList { get; }
        public IState State { get; set; }

        public AvailableState Available { get; }
        public CheckedOutState CheckedOut { get; }

        public void CheckOut(User user)
        {
            State.CheckOut(user);
        }

        public void PlaceHold(User user)
        {
            State.PlaceHold(user);
        }

        public void Return(User user)
        {
            State.Return(user);
        }
    }
}
