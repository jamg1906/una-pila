namespace aStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            humbleStack miPila = new humbleStack();
            Console.WriteLine(miPila.Count);
            Console.WriteLine(miPila.Peek());
            Console.WriteLine(miPila.Pop());
            miPila.Clear();

            Console.WriteLine(miPila.Push("a"));
            Console.WriteLine(miPila.Push("b"));
            Console.WriteLine(miPila.Push("c"));
            Console.WriteLine(miPila.Count);


            Console.WriteLine(miPila.Exists("a"));
            Console.WriteLine(miPila.Exists("b"));
            Console.WriteLine(miPila.Exists("c"));
            Console.WriteLine(miPila.Exists("j"));

            Console.WriteLine(miPila.Pop());
            Console.WriteLine(miPila.Pop());
            Console.WriteLine(miPila.Pop());
            Console.WriteLine(miPila.Pop());

            Console.WriteLine(miPila.Push("jamg1906"));
            Console.WriteLine(miPila.Peek());
            Console.WriteLine(miPila.Count);
            Console.WriteLine(miPila.Pop());


            miPila.Clear();
            Console.WriteLine(miPila.Push("c"));
            Console.WriteLine(miPila.Exists("c"));
            Console.WriteLine(miPila.Exists("j"));
            Console.WriteLine(miPila.Count);

            Console.WriteLine(miPila.Pop());
            Console.WriteLine(miPila.Count);
            Console.WriteLine(miPila.Exists("j"));








        }
    }
}