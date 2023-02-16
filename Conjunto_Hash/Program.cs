namespace Hash_Conjunto;

class Program
{
    static void Main()
    {
        HashSet<int> pares = new HashSet<int>();
        HashSet<int> impares = new HashSet<int>();

        for(int i=0; i<5; i++)
        {
            pares.Add(i*2);
            impares.Add((i*2) + 1);
        }
        //Creamos un CONJUNTO
        //1º Creamos un HashSet de los pares
        HashSet<int> numeros = new HashSet<int>(pares);

        //2ºUnimos el HashSet nuevo de pares con los impares anteriores
        numeros.UnionWith(impares);

        foreach(int local in numeros)
        {
            Console.Write(local);
        }
    }
}