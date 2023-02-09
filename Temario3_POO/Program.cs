namespace Listas_enlazadas;

class Program
{
    static void Main(string[] args)
    {
        //Seria ListaEnlazada, pero para tener las dos formas lo he llamado diferente
        Iterador<int> listaEnlazada = new Iterador<int>();

        for (int i = 0; i < 100; i++)
        {
            listaEnlazada.Add(i);
        }

        /*foreach(int num in listaEnlazada)
        {
            Console.WriteLine(num);
        }*/

        //Se sustituye por el foreach
        IEnumerator<int> iterador = listaEnlazada.GetEnumerator(); //IEnumerator es la interfaz no clase que ya está creada

        while (iterador.MoveNext())
        {
            Console.WriteLine(iterador.Current);
        }
    }
}
