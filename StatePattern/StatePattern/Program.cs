using StatePattern;

Book book = new Book();
book.Name = "Lord of the Rings: Return of the King";

User user1 = new User(1, "User_1");
User user2 = new User(2, "User_2");
User user3 = new User(3, "User_3");

book.PlaceHold(user1);
book.CheckOut(user1);

book.Return(user2);
book.CheckOut(user2);
book.PlaceHold(user2);
book.PlaceHold(user3);

book.Return(user1);
book.PlaceHold(user3);
book.PlaceHold(user1);

book.Return(user2);
book.Return(user3);
book.Return(user1);
