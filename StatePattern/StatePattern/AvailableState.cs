using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class AvailableState : IState
    {
        private Book _Book;

        public AvailableState(Book book)
        {
            _Book = book;
        }

        public void CheckOut(User user)
        {
            Console.WriteLine($"{user.Username} checked out {_Book.Name}.");
            _Book.State = _Book.CheckedOut;
            _Book.CurrentUser = user;
        }

        public void PlaceHold(User user)
        {
            Console.WriteLine($"Book is available now and a hold cannot be placed. Please check out book.");
        }

        public void Return(User user)
        {
            Console.WriteLine("Unable to return book. It is not currently checked out!");
        }
    }
}
