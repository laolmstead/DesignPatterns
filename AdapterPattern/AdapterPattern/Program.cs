using AdapterPattern;

Circle circle = new Circle();
circle.Radius = 5.0;

Square square = new Square();
square.SideLength = 8.0;

Triangle triangle = new Triangle();
triangle.Heigth = 4.0;
triangle.Base = 6.0;

IShape shape = new CircleAdapter(circle);
Console.WriteLine($"Shape: {shape.Name} | Area: {shape.Area}");

shape = new SquareAdapter(square);
Console.WriteLine($"Shape: {shape.Name} | Area: {shape.Area}");

shape = new TriangleAdapter(triangle);
Console.WriteLine($"Shape: {shape.Name} | Area: {shape.Area}");
