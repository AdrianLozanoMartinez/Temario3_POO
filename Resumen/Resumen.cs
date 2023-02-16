/*Uso de For
    * Array[,] Multimensional -> For
         
    * Array[][] Irregular -> For y Foreach
         
    * Lista -> For y Foreach
    * Lista enlazada / doble -> Foreach (No permite acceso aleatorio[i], sino lineal) y while(pero eliminando elementos)
    * Cola FIFO -> Foreach o while(pero eliminando elementos)
    * Pila LIFO -> Foreach o while(pero eliminando elementos)
    * Diccionario -> For(solo con int), 
                     Foreach(int local in numbers[key]) Console.WriteLine($"{local}: {numbers[local]}");
                     Foreach(KeyValuePair<string, int>local in numbers) Console.WriteLine($"{local.Key}: {local.Value}");
         

//Con valores
    * Array[,] Multidimensional
                                //[Filas(0),Columnas(1)]
    int[,] multimensional = new int[2, 3] { 
        { 1, 2, 3 }, //1º FILA y 3 columnas 
        { 3, 4, 5 }  //2º FILA y 3 columnas 
    };

    * Array[][] Irregular 
         
    int[][] arrayIrregular = new int[][] { 
        new[]{ 0, 1, 2, 3 },      //Cada new es una Fila, dentro de ella son Columnas (0,1,2,3)
        new[]{ 5, 6, 7, 8, 9 }
    };
         
    * Lista
    List<int> lista = new List<int>() { 7, 2, 3 };
         
    * Lista enlazada / doblemente enlazada
    LinkedList<int> listaEnlazada = new LinkedList<int>(new[] { 1, 2, 3});
         
    * Iterador
    IEnumerator<int> iterador = listaEnlazada.GetEnumerator();
    
    * Cola - FIFO
    Queue<int> cola = new Queue<int>(new[] { 1, 2, 3 });

    * Pila - LIFO
    * Stack<int> pila = new Stack<int>(new[] {1, 2, 3});
    
    * Diccionario
    Dictionary<string, int> diccionario = new Dictionary<string, int>() { { "uno", 1 }, { "dos", 2 } };
    
    * Hash
    * Hashtable datos = new Hashtable();
*/
