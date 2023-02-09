namespace Implementacion2_Lista_Enlazadas;
//PARA PRACTICAR
class ListaEnlazada<T>
{
    private class Node<T>
    {
        public T Datos { get; set; }
        public Node<T> Next { get; set; }
    }

    private Node<T> head;

    public ListaEnlazada()
    {
        head = null;
    }

    public void Add(T item)
    {
        Node<T> node = new Node<T>
        {
            Datos = item
        };

        if(head == null)
        {
            head = node;
        }
        else
        {
            Node<T> last = head;

            while(last.Next != null)
            {
                last = last.Next;
            }

            last.Next = node;
        }
    }

    public void Delete(T item)
    {
        if(head != null)
        {
            if(head.Datos.Equals(item))
            {
                head = head.Next;
            }
            else
            {
                Node<T> match = head.Next;
                Node<T> before = head;

                while(match != null && !match.Datos.Equals(item))
                {
                    before = match;
                    match = match.Next;
                }

                if(match != null)
                {
                    before.Next = match.Next; //Diría que es igual que match = match.Next; PREGUNTAR LA PROFE
                }
            }
        }
    }
}
