public class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public Dog(string name, string? breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping... Zzz");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"{Name} is eating {food}");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is playing and wagging their tail!");
    }

    public string GetInfo()
    {
        return $"{Name} is a {Age} year old {Breed}";
    }
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}