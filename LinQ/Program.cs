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


        //20-02-2024
        //customer.where(cust => cust.City == "London").OrderBy Descending(cust => cust.Name).Select(cust => cust.ToString.Tolower())
        //Console.ReadKey(); -> Espera una tecla para salir o que haga una acción
        //order by es ascendente por defecto
        //join une un dato en comun entre dos tablas que no estaban relacionadas
        //group agrupa segun una condicion, si es ciudad ya te lo agrupa si es de malaga, marbella, algecias...
        //pg12 -> custoGro..Key 1º muestra la ciudad(marbella...) y el customer.name -> nombre de cliente, where gru.count > 2 grupo que tenga mas de 2 clientes
        //customer.GroupBy(c=>c.City.where(g=>g.Count()>2).OrderBy(g=>g.Key)
        //Count()-> Método que mira si es array usa lenght si es lista cont sino lo tiene que contar manualmente
        //No hay nulo en LYQuest, las colecciones no pueden ser nulos pero si puede ser vacía o llevar elementos(esos elementos pueden ser nulo)
        //En where se puede poner que devuelva elementos que no sean nulos, y ahorramos el if -> where cust != null && cust.city...Se comprueba siempre primero si es null
        //pg 16-> customer.where(c=>c.NameStartWith("AB")).OrderBy(c=>c.Name).Select(C=>c.NAmeToUpper()); -> es igual que si en base dice que empiece en AB-> Name LIKE 'AB%'
        //Si ponemos dos where...despues del select-> where((numero,indice) => indice >= 21 && indice <= 30) o otra opción mejor
        //.Select(C=>c.NAmeToUpper()).Skip(21).Take(9); ->Skip son los 21 primeros incluyendo el 21 y coge los 9. Este es más efectivo que el de arriba, porque el de arriba coje todos los elementos(si hay un millon lo coge) pero este solo los 21
        //Podemos meter en un metodo:
        /*
         IEnumerable<string> Customer(string start) //manda la letra que va a empezar
         customer.where(c=>c.NameStartWith(start))
                 .OrderBy(c=>c.Name)
                 .Select(C=>c.NAmeToUpper()).Skip(21).Take(9);
         
         */

        //cuando tiene clave foranea no se hace join...ECHADO FOTO -> Customer son la tabla de cliente. pg19 -> IGNORAR AHORA HASTA EL ÚLTIMO TEMA



    }
}