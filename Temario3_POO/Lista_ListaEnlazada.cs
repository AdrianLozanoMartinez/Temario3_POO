namespace Temario3_POO
{
    class Lista_ListaEnlazada
    {
        static void Main()
        {
/////////////LISTA

            //Igual que array pero se puede añadir y quitar datos fácilmente y cuando se quiera

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
            numbers.RemoveAt(1); //Borra la 2º posición. EXISTE MÁS REMOVE

            foreach (int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            Console.WriteLine("\nTotal de elementos de la lista");
            int count = numbers.Count; //Número de elementos


            Console.WriteLine(count);

/////////////LISTA ENLAZADA
            LinkedList<int> numbers2 = new LinkedList<int>(new[] { 1, 2, 3});

            foreach(int number in numbers2)
            {
                Console.Write(number);
            }
        }
    }
}