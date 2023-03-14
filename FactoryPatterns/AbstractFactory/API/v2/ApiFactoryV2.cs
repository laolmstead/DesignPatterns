using AbstractFactory.API.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.API.v2
{
    public class ApiFactoryV2 : IApiFactory
    {
        public IEnumerable<Post> GetAllPosts()
        {
            List<Post> posts = new List<Post>();

            PostV2 post1 = new PostV2();
            post1.Username = "jane_doe";
            post1.CreatedDate = DateTime.Now;
            post1.Content = "Hello World!";
            post1.Location = "Topeka, Kansas";
            posts.Add(post1);

            PostV2 post2 = new PostV2();
            post2.Username = "world";
            post2.CreatedDate = DateTime.UtcNow;
            post2.Content = "Hello Jane Doe!";
            post2.Location = "Cleveland, Ohio";
            posts.Add(post2);

            PostV2 post3 = new PostV2();
            post3.Username = "john_doe";
            post3.CreatedDate = DateTime.MinValue;
            post3.Content = "Shared Jane Doe's Post: 'Hello World!'";
            post3.Location = "Phoenix, Arizona";
            posts.Add(post3);

            PostV2 post4 = new PostV2();
            post4.Username = "world";
            post4.CreatedDate = DateTime.MaxValue;
            post4.Content = "World liked John Doe's Post'";
            post4.Location = "Ashville, North Carolina";
            posts.Add(post4);

            return posts.AsEnumerable();
        }
    }
}
