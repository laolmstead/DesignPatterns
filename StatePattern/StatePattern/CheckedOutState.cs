using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CheckedOutState : IState
    {
        private Book _Book;

        public CheckedOutState(Book book)
        {
            _Book = book;
        }

        public void CheckOut(User user)
        {
            Console.WriteLine($"Book is already checked out by {_Book.CurrentUser?.Username}! Please place a hold on {_Book.Name}.");
        }

        public void PlaceHold(User user)
        {
            if (_Book.HoldList.Contains(user))
            {
                Console.WriteLine($"User {user.Username} has already placed a hold on this book. Please be patient - your book will be available soon.");
                return;
            }

            _Book.HoldList.Enqueue(user);
            Console.WriteLine($"User {user.Username} has placed a hold on {_Book.Name}.");

        }

        public void Return(User user)
        {
            if (user.Equals(_Book.CurrentUser))
            {
                Console.WriteLine($"User {user.Username} has returned book {_Book.Name}. Book is now available");
                _Book.CurrentUser = null;
                _Book.State = _Book.Available;
                try
                {
                    User holdUser = _Book.HoldList.Dequeue();
                    if (holdUser != null)
                        _Book.State.CheckOut(holdUser);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Hold list empty. Book is now available.");
                }
            }
        }
    }
}
