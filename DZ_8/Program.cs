namespace DZ_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя Пёселя: ");
            string dogName = Console.ReadLine();
            Dog dog = new Dog();
            dog.SetName(dogName);
            Console.WriteLine($"Кличка Пёселя - {dog.GetName()}");
            dog.Eat();
        }

        abstract class Animal
        {
            public string Name { get; set; }

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;

            }

            public abstract void Eat();

        }
        class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine($"{Name} Хрум Хрум.");

            }


        }

    }

}