namespace Dictionary;

class Program
{
    static void Main()
    {

        Dictionary<string, int> vacio = new Dictionary<string, int>();

        Dictionary<string, int> numbers = new Dictionary<string, int>() { { "uno", 1 }, { "dos", 2 } };//Key: no se puede repetir.
                                                                                                       //Valor se puede repetir

        numbers.Add("tres", 3); //Añade la definición y número 3

        numbers.GetValueOrDefault("uno"); //Devuelve el valor de la key SIN ELIMINAR,
                                          //el resto de lista elimina al coger,
                                          //sino existe devuelve nulo o 0
                                          //(Funciona como un bool, se podría poner un if)

        int count = numbers.Count(); //Número de elementos


        //NO RECOMENDADO mejor foreach
        Dictionary<int, string> numbersInt = new Dictionary<int, string>() { { 1, "uno" }, { 2, "dos" }, { 3, "tres" } };
        for (int i = 1; i <= 3; i++)//Si las KEYS son INT se puede usar
        {
            Console.WriteLine($"{i}: {numbersInt[i]}");
        }

        Console.WriteLine();

        //RECOMENDADO 1
        foreach(string key in numbers.Keys) //numbers.keys -> coge el conjunto de CLAVES y no valor
        {
            Console.WriteLine($"{key}: {numbers[key]}"); //numbers[key] coge el valor
        }

        Console.WriteLine();

        //RECOMENDADO 2
        foreach (KeyValuePair<string, int>pair in numbers) 
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}"); //{pair.key}: coge CLAVE. {pair.Value}: coge VALOR
        }

        

        //Diccionario (containskey) y en Lista y lista enlazada Contains -> Si contiene
    }
}