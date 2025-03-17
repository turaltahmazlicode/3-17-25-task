namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Garfield", new DateTime(2020, 1, 1));
            Dog dog = new Dog("Garfield", new DateTime(2020, 1, 1), true);
            Bird bird = new Bird("Garfield", new DateTime(2020, 1, 1), true);
            Bear bear = new Bear("Garfield", new DateTime(2020, 1, 1), true);
        }
    }
}
