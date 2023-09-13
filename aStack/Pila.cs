using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aStack
{
    public class humbleStack   
    {
        private Nodo? headNode = null;
        private int count;
        public int Count { get { return count; } }

        public void Clear()
        {
            headNode = null;
            count = 0;
        }
        public string Push(string value)
        {
            if(headNode == null)
            {
                headNode = new Nodo(value);
                count++;
                return headNode.valor;
            }

            Nodo newNode = new Nodo(value, headNode);
            headNode = newNode;
            count++;
            return headNode.valor;

        }
        public string Pop()
        {
            if (headNode == null) { return "stack is empty."; }
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
        public string Peek()
        {
            if (headNode == null) { return "stack is empty."; }
            return headNode.valor;
        }
        public bool Exists(string key)
        {
            if (count == 0) { return false; }
            Nodo temporal = headNode;
            while (true)
            {
                if (temporal.valor == key) { return true; }

                temporal = temporal.nodoSiguiente;

                if(temporal == null) { return false; }
            }
        }

    }

    public class Nodo
    {
        public Nodo? nodoSiguiente = null;
        public string valor;
        public Nodo(string Valor, Nodo Siguiente)
        {
            valor = Valor;
            nodoSiguiente = Siguiente;
        }
        public Nodo(string Valor)
        {
            valor = Valor;
        }
    }
}
