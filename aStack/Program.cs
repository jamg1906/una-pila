namespace aStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's try with Dogs!");
            Console.ReadLine();
            Console.Clear();
            humbleStack<Dog> dogStack = new humbleStack<Dog>();
            dogStack.Push(new Dog("Firulais", "Mixed", 3));
            dogStack.Push(new Dog("Rex", "Mixed", 5));
            dogStack.Push(new Dog("Bolt", "Mixed", 2));
            dogStack.Push(new Dog("Lassie", "Mixed", 4));
            dogStack.Push(new Dog("Scooby", "Mixed", 6));
            dogStack.Push(new Dog("Pluto", "Mixed", 1));
            dogStack.Push(new Dog("Goofy", "Mixed", 7));
            dogStack.Push(new Dog("Odie", "Mixed", 8));
            dogStack.Push(new Dog("Snoopy", "Mixed", 9));
            dogStack.Push(new Dog("Hachiko", "Mixed", 10));

            Console.WriteLine(dogStack.Count);
            Console.WriteLine(dogStack.Peek());
            Console.WriteLine(dogStack.Pop());
            Console.WriteLine(dogStack.Count);
            //Console.WriteLine(dogStack.Exists(new Dog("Bolt", "Mixed", 2)));

            foreach (var dog in dogStack)
            {
                Console.WriteLine(dogStack.Count);
                dog.Bark();
                dog.Eat("Pizza");
                dog.Sleep();
                dog.GetInfo();
                dogStack.Pop();

            }
            Console.WriteLine(dogStack.Count);
            dogStack.Clear();
            
        }
    }
}