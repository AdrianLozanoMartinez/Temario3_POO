namespace Temario3_POO;

class ListaEnlazadas
{
    static void Main_() //He puesto_ para que se ejecute el otro, pero no debe llevarlo para funcionar esta parte
    {
/////////////LISTA ENLAZADA
        //pila,cola y LISTA ENLAZADAS NO se puede FOR CON I, pero si while pero eliminando elementos
        LinkedList<int> numbers2 = new LinkedList<int>(new[] { 1, 2, 3});

        foreach(int number in numbers2)
        {
            Console.Write(number);
        }
    }
}