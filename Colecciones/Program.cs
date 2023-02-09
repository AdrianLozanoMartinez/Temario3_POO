namespace Colecciones
{
    //Una de ellas es lista enlazada
    //IEnumerable para poder enumerar

    //Interfaz
    //IList  es la ijnterfaz para trabajar con una lista, definde la implementacion de una lista ( count, iteam...

    //pag 47 this[int index] _> this es así siempre no se cambia y se refiere a esa función. Se refiere a la lista
    //_items[index] -> index es la posicion
    //IsSynchroized y SyncRoot -> SE DEJA TAL Y COMO VIENE EN LA DIAPOSITIVA porque no da tiempo en aplicarlo
    //mutex o semaforo -> hilos no se estudia pero se pide mucho en empresa en todos los lenguajes. trabajar por hilo se colpasa menos

    //pg 49 -> se le pasa a ienumerator un array por istancia
    //pg 50 -> EnsureCapacity asegura que tenga items ese tamaño size+1. Add devuele la posición del último elemento metido, por eso se pone cont-1 porque antes el size hemos sumado 1. size++
    //pg51 ponemos count++ para avanzar en el array en el while
    //pg52 devuelve la posicion del elmento pasado. devuelve menos 1 porque no hay posicion en el array sino es corecto, si lo es devuekve la posicion count
    //pg52 copyTo-> array metemos el item[i] en la posicion 1(1posicion seria0) + index
    //Add añade al final, insert donde se indique
    //pg53 size +1 crea una posicion nueva.
    //Pasamos el array e indice origen(posicion que va a copiar), array e indice +1 de destino.se duplica en el Copy lo que desplaza, para luego suplantarlo. Count -index es la cantidad de elemento que quieres mover.

    /*
     Array.Copy(_items(array de origen(1234)), index(indice pasado y donde empieza a copiar, ejemplo 2 que contiene el 3), 
                _items(array de destino que es el mismo(1234), index+1(nos da la posicion +1 de la dada para duplicar la posicion elegida para luego meterle el dato,
                Count - index (cantidad de elemento que quieres mover)
     */

    //Indexof da la posicion para poder borrar dicha posicion en removeAt

    //remove hace al reves de insert pero lo desplaza a la izquierda en lugar d ela derecha.
    //pg 53 en rmeove -> Usamos null para que el recolector de basura lo ignore al no borrarlo y no continue en memoria para ahorrar memoria

    //pg54 current es el valor que te devuelve en el foreach e interados
    //

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}