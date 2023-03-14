using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.API.v1
{
    public class ApiFactoryV1 : IApiFactory
    {
        public IEnumerable<Post> GetAllPosts()
        {
            List<Post> posts = new List<Post>();

            PostV1 post1 = new PostV1();
            post1.Username = "jane_doe";
            post1.CreatedDate = DateTime.Now;
            post1.Content = "Hello World!";
            posts.Add(post1);

            PostV1 post2 = new PostV1();
            post2.Username = "world";
            post2.CreatedDate = DateTime.UtcNow;
            post2.Content = "Hello Jane Doe!";
            posts.Add(post2);

            PostV1 post3 = new PostV1();
            post3.Username = "john_doe";
            post3.CreatedDate = DateTime.MinValue;
            post3.Content = "Shared Jane Doe's Post: 'Hello World!'";
            posts.Add(post3);

            PostV1 post4 = new PostV1();
            post4.Username = "world";
            post4.CreatedDate = DateTime.MaxValue;
            post4.Content = "World liked John Doe's Post'";
            posts.Add(post4);

            return posts.AsEnumerable();
        }
    }
}
