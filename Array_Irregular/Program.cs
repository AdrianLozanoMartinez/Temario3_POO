namespace Array_Irregular;

class Program
{
    static void Main()
    {
        //Declarar Array Irregular vacío
        int[][] vacio = new int[0][];

        //Declarar Array Irregular
        int[][] arrayIrregular = new int[][] { 
            new[]{ 0, 1, 2, 3 },      //Cada new es una Fila, dentro de ella son Columnas (0,1,2,3)
            new[]{ 5, 6, 7, 8, 9 },
            new[]{ 10, 11, 12 },
            new[]{ 15, 16, 17, 18, 19 }
        };

        //Recorrer - Opción 1
        for (int i = 0; i < arrayIrregular.Length; i++) //Filas (new)
        {
            for(int j = 0; j < arrayIrregular[i].Length; j++) //Columnas (0,1,2,3). De cada fila cogemos las columnas que hay
            {
                int number = arrayIrregular[i][j]; //Pasamos a una variable de tipo entero el array irregular
                Console.Write(number + "\t"); //Mostramos cada fila sus columnas
            }
            Console.WriteLine();  //Realizamos un salto para que se vea en la siguiente fila las
                                  //columnas correspondientes
        }

        Console.WriteLine();

        //Recorrer - Opción 2
        foreach (int[] numbers in arrayIrregular) //Filas (new), Metemos el array irregular en un array simple
        {
            foreach(int number in numbers) //Columnas (0,1,2,3), Metemos el array anterior en una
            {                              //variable que recorremos
                Console.Write(number + " \t"); //Mostramos cada fila sus columnas
            }
            Console.WriteLine();  //Realizamos un salto para que se vea en la siguiente fila las
                                  //columnas correspondientes
        }
    }
}