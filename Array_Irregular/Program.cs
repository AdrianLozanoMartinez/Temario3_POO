namespace Array_Irregular;

class Program
{
    static void Main()
    {
        int[][] vacio = new int[0][];

        int[][] arrayIrregular = new int[][] {
            new[]{ 0, 1, 2, 3 },
            new[]{ 5, 6, 7, 8, 9 },
            new[]{ 10, 11, 12 },
            new[]{ 15, 16, 17, 18, 19 }
        };

        for(int i = 0; i < arrayIrregular.Length; i++) //Filas
        {
            for(int j = 0; j < arrayIrregular[i].Length; j++) //Columnas
            {
                int number = arrayIrregular[i][j];
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        foreach (int[] numbers in arrayIrregular)
        {
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}