namespace Cola;

class Program
{
    static void Main()
    {
        /*
         Colección de datos de un mismo tipo que nos permite almacenar información en colas
         de tipo FIFO (el primero que entra es el primero que sale)
        */

        Queue<int> vacio = new Queue<int>();

        Queue<int> numbers = new Queue<int>(new[] { 1, 2, 3 });
        numbers.Enqueue(10); //Inserta al final de la cola
        numbers.Dequeue(); //Devuelve el primero de la cola y lo borra
        Console.WriteLine(numbers.Dequeue()); //Devuelve, borra y muestra el primero de la cola

        foreach(int number in numbers)
        {
            Console.Write(number); //2,3,10
        }

        int count = numbers.Count; //Número de elementos
        Console.WriteLine(count); //3 elementos
    }
}