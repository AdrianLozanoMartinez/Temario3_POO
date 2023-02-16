namespace Listas;

class Program
{
    static void Main()
    {
        /*Igual que array pero se puede añadir y quitar datos fácilmente y cuando se quiera
          Tiene que ir dentro de un método

        List<List<int[]>> list = new List<List<int[]>>(){}; -> Lista de lista de array de entero*/


        List<int> vacio = new List<int>();

        List<int> numbers = new List<int>() { 7, 2, 3 };

        Console.WriteLine("Elementos de la lista");
        for (int i = 0; i < numbers.Count; i++) //Ponemos Count en lugar de Length
        {
            Console.Write(numbers[i]);
        }
        Console.WriteLine();

        Console.WriteLine("\nAñadimos e insertamos en la lista");
        numbers.Add(4);
        numbers.Insert(0, 9); //Inserta un 9 en la 1º posición
        numbers.RemoveAt(1); //Borra la 2º posición, en () elige la posicion. EXISTE MÁS REMOVE. Elimina la 1º ocurrencia (igual)

        foreach (int number in numbers)
        {
            Console.Write(number);
        }
        Console.WriteLine();

        Console.WriteLine("\nTotal de elementos de la lista");
        int count = numbers.Count; //Número de elementos


        Console.WriteLine(count);
    }
}