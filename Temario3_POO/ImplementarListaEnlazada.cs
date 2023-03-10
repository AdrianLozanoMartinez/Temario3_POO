namespace Listas_enlazadas;
//FUNCIONAMIENTO POR DENTRO DE UNA LISTA ENLAZADA
class ImplementarListaEnlazada<T>
{
    private class Node<T> //Solo puede verse y usarse por la clase de arriba, que está dentro, el padre
    {
        //Si hacemos private atributo solo lo lee la clase Node no el padre (ListaEnlazada)
        public T Datos { get; set; } //Guarda datos. Se puede usar solo por la parte de arriba, no por otras clases
        public Node<T> Next { get; set; } //NODO/Siguiente
    }

    //protected Node<T> Metodo() //tiene que coincidir el nivel de protección con el de arriba, pero private no vale, porque no es absesible
    //{

    //}

    //Atributo/NODO
    private Node<T> head; //Cabecera/inicio

    //Constructor
    public ImplementarListaEnlazada()
    {
        head = null;
    }

    public void Add(T item) //Elegimos si queremos por delante o detras, una fila/FIFO o pila/LIFO
    {
        //NODO vacío que metemos el dato recibido
        Node<T> node = new Node<T> //Creamos una instancia donde se crea una lita que es como un array pero que no acaba
        {
            Datos = item //metemos a los Datos el item mandado por parámetro
        };

        if (head == null) //Cuando el 1º/cabecera está vacío
        {
            head = node; //MEtemos el nodo del nuevo dato como cabecera al estar vacía esta
        }
        else //Cuando no está vacío el 1º/cabecera 
        {
            Node<T> last = head; //Creamos otro nodo donde metemos head de ese modo siempre comenzamos por el head

            while (last.Next != null) //Mientras el siguiente del last no sea nulo
            {
                last = last.Next; //Le metemos la posición last siguiente en last porque entonces no es el último
            }//Si fuera null se sale porque ya el Next ya es el último
            last.Next = node; //Metemos el dato en el último
        }

    }
    public void Delete(T item)
    {
        if (head != null)  //Si la cabecera no es nula
        {
            if (head.Datos.Equals(item)) //Si los datos que están en la cabecera es igual que el que quiero eliminar
            {
                head = head.Next; //Metemos el siguiente de la cabecera en la cabecera, para que el siguiente sea la
                                  //cabecera, y eliminamos la cabecera anterior para asignarla al siguiente
            }
            else
            {
                Node<T> match = head.Next; //match por coincidencia, comenzamos por el siguiente de
                                           //la cabecera, ya que en el if dijimos que no es la cabecera

                Node<T> before = head; //Creamos una variable para coger la anterior de la siguiente
                                       //Para poder borrar, ya que estamos localizando el que queremos borrar
                                       //before ya no es nulo porque coge la cabecera y ya hemos restringido con el if

                while (match != null && !match.Datos.Equals(item)) //ponemos match != null para evitar la ecepción 
                {                                                  //de !match.Datos.Equals(item)
                    before = match; //Metemos la posicion antes del next
                    match = match.Next; //Metemos la siguiente posición
                }

                if (match != null) //Si no es nulo y coincide(coincidencia se ve en while)
                {
                    //Diría que es igual que match = match.Next; PREGUNTAR LA PROFE
                    before.Next = match.Next; //Metemos la siguiente posición en la anterior,
                                              //de esa manera eliminamos la anterior
                }

            }
        }
    }
}
