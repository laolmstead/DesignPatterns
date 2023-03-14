using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.API.v2
{
    public class PostV2 : Post
    {
        public PostType PostTypeV2 { get; } = (PostType)RandomNumberGenerator.GetInt32(1, 6);
        public string? Location { get; set; }
    }
}
