using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aStack
{
    public class humbleStack<T> : IEnumerable<T>
    {
        private Nodo<T>? headNode = null;
        private int count;
        public int Count { get { return count; } }

        public void Clear()
        {
            headNode = null;
            count = 0;
        }
        public T Push(T value)
        {
            if(headNode == null)
            {
                headNode = new Nodo<T>(value);
                count++;
                return headNode.valor;
            }

            Nodo<T> newNode = new Nodo<T>(value, headNode);
            headNode = newNode;
            count++;
            return headNode.valor;

        }
        public T Pop()
        {
            if (headNode == null) { return default(T); }
            if (headNode.nodoSiguiente == null) {
                var temporal = headNode.valor;
                Clear();
                return  temporal; 
            }
            var temp = headNode.valor;
            headNode = headNode.nodoSiguiente;
            count--;
            return temp;

        }
        public T Peek()
        {
            if (headNode == null) { return default(T); }
            return headNode.valor;
        }
        public bool Exists(string key)
        {
            if (count == 0) { return false; }
            Nodo<T> temporal = headNode;
            while (true)
            {
                if (temporal.valor.Equals(key)) { return true; }

                temporal = temporal.nodoSiguiente;

                if(temporal == null) { return false; }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Nodo<T>? current = headNode;
            while (current != null)
            {
                yield return current.valor;
                current = current.nodoSiguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

    public class Nodo<U>
    {
        public Nodo<U>? nodoSiguiente = null;
        public U valor;
        
        public Nodo(U Valor, Nodo<U> Siguiente)
        {
            valor = Valor;
            nodoSiguiente = Siguiente;
        }
        public Nodo(U Valor)
        {
            valor = Valor;
        }
    }
}
