namespace arbol_implementar;
//SE USA PARA BUSCAR EFICIENTEMENTE
class Arbol<T> where T : IComparable<T> //Decimos que T es para la igualdad de Comparable
{
    private class Nodo<T>
    {
        //NO SE CREA ATRIBUTOS PORQUE AL SER PRIVADO NO SE PUEDE SACAR POR ESO SE USA PROPIEDADES
        public T Value { get; set; }

        public Nodo<T> Izquierda { get; set; } //HACE REFERENCIA A UN NODO IZQUIERDO

        public Nodo<T> Derecha { get; set; } //HACE REFERENCIA A OTRO NODO DERECHO

    }

    private Nodo<T> raiz;

    public void Insertar(T item)
    {
        Nodo<T> nodo = new Nodo<T>() //Equivalente a Nodo<T> nodo = new Nodo<T>(){Value = item};
        {
            Value = item //Metemos el aprametro en la variable Value
        };

        if (raiz == null)
        {
            raiz = nodo; //El elemento que metamos a la raiz del tiron al ser nula, es decir al no tener nada la raiz   
        }
        else
        {
            Nodo<T> actual = raiz; //Meto el inicio, raiz

            do {
                if (actual.Value.CompareTo(item) < 0) //raiz menor que item. Al ser menor se va a la izquierda el orden que hemos elegido, sino a la derecha ptra opcion
                {
                    if (actual.Izquierda == null) //Esta vacio es el ultimo
                    {
                        actual.Izquierda = nodo; //damos valor, se hace porque sino se quedamos sin valor el último elemento
                        actual = null; //para salir al ser último elemento
                    }
                    else
                        actual = actual.Izquierda; //Que es menor se viene aqui
                }
                else
                {
                    if(actual.Derecha == null)
                    { 
                        actual.Derecha = nodo;
                        actual = null;
                    }
                    else
                        actual = actual.Derecha; //Si es mayor
                }
            } 
            while(actual != null);
        }
    }

    public void Eliminar(T item) //Eliminar siempre en todo la 1º ocurrencia al menos que quiera eliminar todos los elementos
    {
        if (raiz == null)
            throw new InvalidOperationException();

            Nodo<T> actual = raiz;
            Nodo<T> ultimo = null;

        do
        {
                int comparteTo = actual.Value.CompareTo(item);

                if (comparteTo > 0)  //Si es menor a la izquierda
                {
                    ultimo = actual;
                    actual = actual.Izquierda; 
                }
                else if (comparteTo < 0)
                {
                    ultimo = actual;
                    actual = actual.Derecha;  //Si es mayor a la derecha
                }
                else //actual es el hijo
                {
                    //Nodo hoja
                    if (actual.Izquierda == null && actual.Derecha == null)
                    {
                        //árbol solo tiene un nodo y es su raíz
                        if (ultimo == null) //No tiene hojas y es la raiz
                        {
                            raiz = null;
                        }
                        else if (ultimo.Izquierda == actual) //actual es donde estamos   ultimo a mi padre
                            ultimo.Izquierda = null;
                        else
                            ultimo.Derecha = null;
                        /*5
                       3    7
                      2 4  6 8
                        */
                        //la parte 3 y 2 es el lado menor del árbol y 7 y 8 la parte mayor del árbol
                        //Por fuerza SIEMPRE MENOR la parte de la IZQUIERDA y MAYOR los que vayan a la DERECHA
                        //La derecha mayor o igual y la izquierda menor siempre en este caso
                    }
                    else if (actual.Izquierda == null)
                    {
                        if (ultimo.Izquierda == actual)
                            ultimo.Izquierda = actual.Derecha;
                        else
                            ultimo.Derecha = actual.Derecha;
                    }
                    //No tenemos hijo a la derecha
                    else if (actual.Derecha == null)
                    {
                        if (ultimo.Izquierda == actual)
                            ultimo.Izquierda = actual.Izquierda;
                        else
                            ultimo.Derecha = actual.Izquierda;
                    }
                    else
                    {
                        actual.Derecha
                    }
            }
        }
        while (actual != null);
        }
    }
}
