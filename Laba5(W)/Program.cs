class Animal
{
    public string food;
    public string location;

    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное издает звуки");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Животное ест");
    }

    public void Sleep()
    {
        Console.WriteLine("Животное спит");
    }
}

class Dog : Animal
{
    public string Breed { get; set; }

    public override void MakeNoise()
    {
        Console.WriteLine("Собака лает");
    }

    public override void Eat()
    {
        Console.WriteLine("Собака ест кость");
    }
}

class Cat : Animal
{
    public bool Activity { get; set; }

    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мурлычет");
    }

    public override void Eat()
    {
        Console.WriteLine("Кошка ест рыбу");
    }
}

class Horse : Animal
{
    public string Color { get; set; }

    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь фыркает");
    }

    public override void Eat()
    {
        Console.WriteLine("Лошадь пьет воду и кушает сено");
    }
}

class Veterinar
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Лечение животного. Еда: {animal.food}, Местоположение: {animal.location}");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Breed = "Лабрадор";
        dog.food = "Кость";
        dog.location = "Дом";

        Cat cat = new Cat();
        cat.Activity = true;
        cat.food = "Рыба";
        cat.location = "Квартира";

        Horse horse = new Horse();
        horse.Color = "Коричневый";
        horse.food = "Сено";
        horse.location = "Стойло";

        Veterinar vet = new Veterinar();

        vet.TreatAnimal(dog);
        vet.TreatAnimal(cat);
        vet.TreatAnimal(horse);
    }
}
