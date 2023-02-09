namespace Queue;
//pila,cola y lista enlazada no se puede for con i, pero si while pero eliminando elementos
class Program
{
    static void Main()
    {
        //LIFO - 1º Entrar, Último en salir

        Stack<int> vacio = new Stack<int>();

        Stack<int> numbers = new Stack<int>(new[] {1, 2, 3});

        Console.WriteLine($"Ver lo que hay al principio/final de la pila sin tocarlo: {numbers.Peek()}");

        Console.Write($"Antes de agregar y eliminar");
        foreach (int number in numbers)
        {
            Console.Write(" " + number);
        }
        Console.WriteLine();

        numbers.Push(9); //Insertar elemento arriba
        Console.Write($"Después de agregar el (9)");
        foreach (int number in numbers)
        {
            Console.Write(" " + number); 
        }
        Console.WriteLine();
        
        
        numbers.Pop(); //Muestra y borra el elemento de arriba
        Console.Write($"Después de eliminar (El 1º que era el 9)");
        foreach (int number in numbers)
        {
            Console.Write(" " + number);
        }
        Console.WriteLine();
        

        int count = numbers.Count; //Número de elementos
        Console.WriteLine($"Cantidad que hay: {count}");
    }
}