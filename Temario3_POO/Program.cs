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









/*Tipado -> no se usa en parametro, pero si en foreach, metodo. En javascript da igual cambiar de tipo a una variable pero en c# no
 var algo; da error porque no se sabe el valor, hay que darle valor, default no se puede porque es el vakir oir defecto del valor, sin se sabe que valor es...

 
 var a = new { Cantidad = 10 }; -> 1º variable
    a = new { Cantidad = 5 }; -> Variable que sobreescribe

 var d = new { Cantidad = 4}; -> Nueva variable*/
