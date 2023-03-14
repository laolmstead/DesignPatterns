using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.API.v1
{
    public class PostV1 : Post
    {
        public PostType PostTypeV1 { get; } = (PostType)RandomNumberGenerator.GetInt32(1, 5);
    }
}
