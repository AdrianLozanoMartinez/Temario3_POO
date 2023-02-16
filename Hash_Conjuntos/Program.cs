using System.Collections;

namespace Hash_Conjuntos;

class Program
{
    static void Main()
    {
        /*
            * Indice -> Se refiere al hash code -> John y Sandra Dee tiene mismo hash code, luego para diferenciarlo hace un Equals.
            * NO PARA NUEVOS DESARROLLOS, para los nuevos se usan Dictionary<Tkey,TValue>
            * clase se puede cambiar excepto string,los struct tampoco se puede, el hash no cambia pero el contenido si se puede.
            * pg28
contiene elemento dentro de un conjunto, el anterior es un diccionario clave = valor


        */

        Hashtable datos = new Hashtable();
        datos.Add("txt", "notepad.exe"); //Añadimos par clave.
                //clave   valor

        string programa = (string)datos["txt"]; //Obtener valor de la clave

        bool tieneClave = datos.Contains("txt"); //Nos devuelve boolean si se obtiene la clave

        int count = datos.Count; //Número de elementos
        
    }
}