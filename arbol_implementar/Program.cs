using Arbol_Implementacion;

namespace BinaryTreeExample;
/*USado en sistema de carpeta de SO y sistema XML o HTML
  Arbol binario -> si es mayor o igual se pone a la derecha si es menor a la izquierda
  Pg 29 -> el 2 y el 5 son descendientes del 1*/
class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();

        tree.Add(5);
        tree.Add(2);
        tree.Add(8);
        tree.Add(3);
        tree.Add(4);
        tree.Add(6);
        tree.Add(7);
        tree.Add(0);
        tree.Add(10);

        tree.Remove(4);

        /*Random random = new Random();

        for (int i = 0; i < 30; i++)
        {
            tree.Add(random.Next(100));
        }*/

        Console.WriteLine("Preorden: [{0}]", string.Join(", ", tree.PreOrder()));
        Console.WriteLine("Inorden: [{0}]", string.Join(", ", tree.InOrden()));
        Console.WriteLine("Postorden: [{0}]", string.Join(", ", tree.PostOrder()));
        Console.WriteLine(tree.Contains(10));

        Console.Write("Iterador: ");
        foreach (int i in tree) Console.Write(i);
    }
}