namespace Dictionary;

class Program
{
    static void Main()
    {

        Dictionary<string, int> vacio = new Dictionary<string, int>();

        Dictionary<string, int> numbers = new Dictionary<string, int>() { { "uno", 1 }, { "dos", 2 } };//Key: no se puede repetir. Valor se puede repetir

        numbers.Add("tres", 3); //Añade la definición y número 3


        //busca la key y te devuelve el valor
        //es el único que coge sin eliminar, el resto de lista elimina
        //Si no encuentra (get) devuelve 0 (Funciona como un bool, se podría poner un if)
        //Si las keys son int se puede usar for con i pero NO RECOMENDADO mejor foreach

        //numbers.keys -> coge el conjunto de CLAVES y no valor. numbers[key] coge el valor
        //{pair.key} {pair.Value} -> coge CLAVE y VALOR

        //Diccionario (containskey) y en Lista y lista enlazada Contains -> Si contiene
    }
}