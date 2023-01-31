namespace Array_Multimensional;

class Program
{
    static void Main()
    {
        int[,] vacio = new int[0, 0];

        int[,] multimensional = new int[2, 3] { //[Filas(0),Columnas(1)]
            { 1, 2, 3 }, //1º FILA y 3 columnas 
            { 3, 4, 5 }  //2º FILA y 3 columnas 
        };

        //Obtener cantidad
        int longitud = multimensional.Length; //Cantidad total -> Filas(1)+Columnas(2): 6 posiciones
        Console.WriteLine($"Total de posiciones de [2, 3], 2*3: {longitud}");

        int cogerFila = multimensional.GetLength(0); //Cantidad total de filas(0)
        Console.WriteLine($"Coge el total de filas que hay: {cogerFila}"); //Muestra 2

        int cogerColumna = multimensional.GetLength(1); //Cantidad total de columnas(1)
        Console.WriteLine($"Coge el total de columnas que hay: {cogerColumna}"); //Muestra 3

        //Recorrer - Opción 1
        for (int i = 0; i < multimensional.GetLength(0); i++) //Hasta un número menos del total de filas
        {
            for (int j = 0; j < multimensional.GetLength(1); j++) //Hasta un número menos del total de columnas
            {
                
            }
        }


        //Recorrer - Opción 2


    }
}