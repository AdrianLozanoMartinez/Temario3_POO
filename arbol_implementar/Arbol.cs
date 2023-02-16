using System.Collections;

namespace Arbol_Implementacion;

class BinarySearchTree<T> : IEnumerable<T> where T : IComparable<T>
{
    private class Node
    {
        public T Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    private Node root;

    public BinarySearchTree() { }

    public BinarySearchTree(IEnumerable<T> items)
    {
        foreach (T item in items) Add(item);
    }

    public void Add(T item)
    {
        Node newNode = new Node() { Value = item };

        // Si la raíz es nula entonces la raíz será un nuevo nodo con el elemento nuevo
        if (root == null)
        {
            root = newNode;
        }
        // Si no, entonces lo vamos a añadir de manera recursiva
        else
        {
            Add(root, newNode);
        }
    }

    private void Add(Node current, Node newNode)
    {
        // Si el valor del nuevo Nodo es menor que el del nodo actual vamos a la izquierda
        if (newNode.Value.CompareTo(current.Value) < 0)
        {
            // Si a la izquierda no hay nada entonce añadimos ahí el nuevo nodo
            if (current.Left == null)
            {
                current.Left = newNode;
            }
            // Si no, llamamos al método recursivamente indicando que el nodo actual va a ser el de la izquierda
            else
            {
                Add(current.Left, newNode);
            }
        }
        // Si no, vamos a la derecha
        else
        {
            // Si a la derecha no hay nada entonce añadimos ahí el nuevo nodo
            if (current.Right == null)
            {
                current.Right = newNode;
            }
            // Si no, llamamos al método recursivamente indicando que el nodo actual va a ser el de la derecha
            else
            {
                Add(current.Right, newNode);
            }
        }
    }

    public void Remove(T item)
    {
        // Creamos las variables current(el nodo actual, es el que su valor tiene que coincidir con item),
        // parent (el padre del nodo actual), isLeftChild un booleano que nos va a indicar si current
        // es hijo izquierdo o derecho del padre
        Node current = root;
        Node parent = root;
        bool isLeftChild = false;

        // Si root es nulo entonces el árbol está vacío y no hacemos nada
        if (root != null)
        {
            // Buscamos el nodo
            while (current != null && item.CompareTo(current.Value) != 0)
            {
                // Antes de ver los hijos guardamos el nodo actual como padre
                parent = current;

                // Si el elemento a buscar es menor que el valor del nodo actual nos vamos a la izquierda
                if (item.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                    isLeftChild = true;
                }
                // Si es mayor, nos vamos a la derecha
                else
                {
                    current = current.Right;
                    isLeftChild = false;
                }
            }

            // Si llegado aquí current no es nulo entonces es que hemos encontrado el nodo a eliminar
            if (current != null)
            {
                // El nodo a aliminar no tienes hijos
                if (current.Right == null && current.Left == null)
                {
                    // Si el nodo a eliminar es la raíz pues entonces la raíz es nulo ya que no tiene hijos
                    if (current == root)
                    {
                        root = null;
                    }
                    else
                    {
                        // Si el nodo a eliminar era hijo izquierdo del padre ahora será nulo
                        if (isLeftChild)
                        {
                            parent.Left = null;
                        }
                        // Si no, el nodo a eliminar era hijo derecho del padre y ahora será nulo
                        else
                        {
                            parent.Right = null;
                        }
                    }
                }
                // Si el nodo a eliminar solo tiene un hijo y es el hijo izquierdo,
                // entonces vamos a reemplazar dicho nodo por su único hijo
                else if (current.Right == null)
                {
                    // Si el nodo a eliminar es la raíz y esta solo tiene un hijo,
                    // pues ahora ese hijo va a ser la raíz
                    if (current == root)
                    {
                        root = current.Left;
                    }
                    else
                    {
                        // Si el nodo a eliminar era hijo izquierdo del padre ahora su hijo izquierdo será
                        // el hijo izquiero del nodo a eliminar
                        if (isLeftChild)
                        {
                            parent.Left = current.Left;
                        }
                        // Si el nodo a eliminar era hijo derecho del padre ahora su hijo derecho será
                        // el hijo izquiero del nodo a eliminar
                        else
                        {
                            parent.Right = current.Left;
                        }
                    }
                }
                // Si el nodo a eliminar solo tiene un hijo y es el hijo derecho,
                // entonces vamos a reemplazar dicho nodo por su único hijo
                else if (current.Left == null)
                {
                    // Si el nodo a eliminar es la raíz y esta solo tiene un hijo,
                    // pues ahora ese hijo va a ser la raíz
                    if (current == root)
                    {
                        root = current.Right;
                    }
                    else
                    {
                        // Si el nodo a eliminar era hijo izquierdo del padre ahora su hijo izquierdo será
                        // el hijo derecho del nodo a eliminar
                        if (isLeftChild)
                        {
                            parent.Left = current.Right;
                        }
                        // Si el nodo a eliminar era hijo derecho del padre ahora su hijo derecho será
                        // el hijo derecho del nodo a eliminar
                        else
                        {
                            parent.Right = current.Right;
                        }
                    }
                }
                // El nodo a eliminar tiene hijo izquierdo y derecho, en este caso tenemos que encontrar
                // un nodo sucesor para reemplazarlo. Para encontrar ese nodo sucesor vamos a intentar
                // buscar el menor valor en el subárbol derecho del nodo a eliminar y luego vamos
                // a la izquierda hasta encontrar un nodo hoja.
                else
                {
                    // Sucesor será el menor de los elementos mayores del nodo a eliminar
                    Node successor = FindSuccessor(current);

                    // Si el nodo a eliminar es la raíz, la raíz será ahora nuestro nodo sucesor
                    if (current == root)
                    {
                        root = successor;
                    }
                    // Si el nodo a eliminar era hijo izquierdo del padre ahora su hijo izquierdo será
                    // el sucesor
                    else if (isLeftChild)
                    {
                        parent.Left = successor;
                    }
                    // Si el nodo a eliminar era hijo derecho del padre ahora su hijo derecho será
                    // el sucesor
                    else
                    {
                        parent.Right = successor;
                    }
                }
            }
        }
    }

    // Encuentra un sucesor y lo prepara para el reemplazo
    private Node FindSuccessor(Node node)
    {
        Node successorParent = node;
        Node successor = node;
        // Empezamos navegando a la derecha
        Node current = node.Right;

        // Buscamos nuestro sucesor yendo siempre a la izquierda
        while (current != null)
        {
            successorParent = successor;
            successor = current;
            current = current.Left;
        }

        // Si el sucesor no es justo el hijo derecho del nodo a eliminar
        if (successor != node.Right)
        {
            // El hijo izquierdo del padre del sucesor pasará a ser el hijo derecho del sucesor
            successorParent.Left = successor.Right;

            // El hijo derecho del sucesor pasará a ser el hijo derecho del elemento a eliminar
            successor.Right = node.Right;
        }

        // El hijo izquierdo del sucesor pasará a ser el hijo izquierdo del elemento a eliminar
        successor.Left = node.Left;

        return successor;
    }

    public bool Contains(T item)
    {
        Node current = root;
        //Node parent = root;
        bool result = false;

        // Buscamos el nodo
        //while (current != null && item.CompareTo(current.Value) != 0) //opción 1
        while (current != null && !result) //opción 2 del profe
        {
            if (item.CompareTo(current.Value) < 0) current = current.Left;
            // Si es mayor, nos vamos a la derecha
            //else current = current.Right; //opción 1
            else if (item.CompareTo(current.Value) > 0) current = current.Right; //opción 2 profe

            //if (current != null) result = true; //opción 1
            else //opción 2 profe
                result = true; //opción 1 y 2
        }
        return result;
    }

    // Raíz, subárbol izquierdo, subárbol derecho
    public T[] PreOrder()
    {
        List<T> result = new List<T>();

        PreOrder(root, result);

        return result.ToArray();
    }

    private void PreOrder(Node current, List<T> list)
    {
        list.Add(current.Value);
        if (current.Left != null) PreOrder(current.Left, list);
        if (current.Right != null) PreOrder(current.Right, list);
    }

    // Subárbol izquierdo, raíz, subárbol derecho
    public T[] InOrden()
    {
        List<T> result = new List<T>(); //lista vacia que abajo se rellena y
                                        //con return lo mandamos

        InOrden(root, result);

        return result.ToArray();
    }

    private void InOrden(Node current, List<T> list)
    {
        if (current.Left != null) InOrden(current.Left, list);
        list.Add(current.Value);
        if (current.Right != null) InOrden(current.Right, list);
    }

    // Subárbol izquierdo, subárbol derecho, raíz 
    public T[] PostOrder()
    {
        List<T> result = new List<T>();

        PostOrder(root, result);

        return result.ToArray();
    }

    private void PostOrder(Node current, List<T> list)
    {
        if (current.Left != null) PostOrder(current.Left, list); //Como puede haber mas izquierdo se va guadando todo a la izquierda, porque es una propiedad 
        if (current.Right != null) PostOrder(current.Right, list); //igual pero de la derecha
        list.Add(current.Value); //Como es solo una raiz se guarda del tiron
    }

    public void Clear()
    {
        root = null;
    }

    //En Orden ITERADOR
    public IEnumerator<T> GetEnumerator()
    {
        //OPCIÓN CORTA DE AQUÍ (contando con IEnumerator IEnumerable.GetEnumerator()) PARA ARRIBA
        return ((IEnumerable<T>)InOrden()).GetEnumerator(); //Se usa IEnumerable porque es genérico, sino fuera genérico no es necesario
                                                            //GetEnumerator actua como iterador(para usar foreach), el GetEnumerator coge el array de InOrden y lo lee/muestra
                                                            //Poner la otra opción que está en la foto, más larga y no necesaria en este caso
        //OPCIÓN LARGA DE AQUÍ PARA ABAJO (contando con IEnumerator IEnumerable.GetEnumerator())
        //return new Enumerator(InOrden()); //Llama al iterador de abajo. NO HACE FALTA, ya que InOrden lo ordena.
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    //OPCIÓN LARGA DE AQUÍ PARA ABAJO
    class Enumerator : IEnumerator<T>
    {
        private T[] _items;
        private int _index;

        public Enumerator(T[] items)
        {
            _items = items;
            Reset();
        }

        public T Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            bool hasElement = _index < _items.Length;

            if(hasElement )
            {
                Current = _items[_index];
                _index++;
            }
            return hasElement;
        }

        public void Reset() 
        {
            _index = 0;
            Current = default;
        }

    }
}
