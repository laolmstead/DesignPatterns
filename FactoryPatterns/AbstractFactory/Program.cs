using AbstractFactory;
using AbstractFactory.API.v1;
using AbstractFactory.API.v2;

ApiFactoryV1 apiFactoryV1 = new ApiFactoryV1();

IEnumerable<Post> postsV1 = apiFactoryV1.GetAllPosts();

Console.WriteLine("Version 1 API Posts:");
foreach (PostV1 postV1 in postsV1)
{
    Console.WriteLine("Retrieved Post: ");
    Console.WriteLine($"{postV1.Id}");
    Console.WriteLine($"{postV1.Username}");
    Console.WriteLine($"{postV1.Content}");
    Console.WriteLine($"{postV1.CreatedDate}");
    Console.WriteLine($"{postV1.PostTypeV1}");
    Console.WriteLine();
}

ApiFactoryV2 apiFactoryV2 = new ApiFactoryV2();

IEnumerable<Post> postsV2 = apiFactoryV2.GetAllPosts();

Console.WriteLine("Version 2 API Posts:");
foreach (PostV2 postV2 in postsV2)
{
    Console.WriteLine("Retrieved Post: ");
    Console.WriteLine($"{postV2.Id}");
    Console.WriteLine($"{postV2.Username}");
    Console.WriteLine($"{postV2.Content}");
    Console.WriteLine($"{postV2.CreatedDate}");
    Console.WriteLine($"{postV2.PostTypeV2}");
    Console.WriteLine($"{postV2.Location}");
    Console.WriteLine();
}