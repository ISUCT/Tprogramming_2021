// See https://aka.ms/new-console-template for more information
using AnimalFabric;

Console.WriteLine("Hello, World!");

Cat cat = new Cat("red", 1, 0, 0, 32, 1, 12, 300.0f);
Mouse mouse = new Mouse();
mouse.LifesCount = 100;
try
{
    Console.WriteLine(mouse.GetFoodCount());
    Console.WriteLine(cat.GetFoodCount());
}
catch (Exception ex)
{
    Console.WriteLine("Видимо вы заставили кошек принести количество еды");
}

Console.ReadLine();
