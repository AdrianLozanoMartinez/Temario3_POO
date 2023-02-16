namespace LinQ;

class Program
{
    static void Main()
    {
        var numeros = Enumerable.Range(0, 100); //Empieza desde posición 0 y coja los 100 números

        var pares = numeros.Where(x => x%2 == 0);//1º se pone los parametros y luego lo que se va a hacer. x ponemos porque es una variable
                                                 //Se suele poner una letra, pero se puede poner palabra, una letra significativa...si fuera casa se pone c

        //Al usarse Count,,,,se ejecuta el where...y nos dice la cantidad de pares que hay
        Console.WriteLine($"Cantidad de números pares: {pares.Count()}");

        var alReves = numeros.Where(x => x % 2 == 0).Reverse();

        Console.WriteLine($"Al reves: {alReves}");

        var ordenarAlReves = numeros.Where(x => x % 2 == 0).OrderByDescending(x => x);

        Console.WriteLine($"Ordenar al reves: {ordenarAlReves}"); //hacer foreach

        var ordenarRaizCuadraada = numeros.Where(x => x % 2 == 0) //Debe ser un bool
                                   .OrderByDescending(x => x)
                                   .Select(x => Math.Sqrt(x));
                                //.Select(Math.Sqrt); -> Funciokanria si fuera mismo tipo, al ser un aprametro x igual que en x

         Console.WriteLine($"Ordenar raiz cuadrada con funcion: {ordenarRaizCuadraada}"); //hacer foreach

        var ordenarRaizCuadraada2 = numeros.Where(x => x % 2 == 0)
                            .OrderByDescending(x => x)
                            .Select(MetodoSqrt); //Podemos meterle un método todos los que se pueda meter funciones, dentro del where, order...

        static double MetodoSqrt(int x) => Math.Sqrt(x); //Funcion que metemos arriba

        Console.WriteLine($"Ordenar raiz cuadrada con método: {ordenarRaizCuadraada2}"); //hacer foreach

        var ordenarRaizCuadraada3 = numeros.Where(EsPar)
                           .OrderByDescending(x => x)
                           .Select(MetodoSqrt);

        static bool EsPar(int x)
        {
            return x%2 == 0;
        }

        Console.WriteLine($"Where con método: {ordenarRaizCuadraada3}"); //hacer foreach


        var paresPares = numeros.Select(x =>
        {
            bool esPar = false;
            esPar = x % 2 == 0;

            return esPar;
        });

        Console.WriteLine($"3º forma, función de varias líneas dentro de Select: {paresPares}"); //hacer foreach


//////////////////////////////////////////////////        //HACER FOREACH EN VEZ DE CONSOLE MENOS EN COUNT    ///////////////////////
        //Al llamar foreach ya si se ejecuta el where de arriba, si no se llama no se ejecuta
        foreach (var x in pares)
        {
            Console.Write(x + " ");
        }


        //llamar al foreach y luego a count gasta mucho tiempo cada vez que se llame a una base de datos...porque ahora estamos en memoria y nos e nota
        //pero lo suyo es meterlo en ToArray o List...

        var paresPares2 = numeros.Select(EsPar).ToArray();





    }
}