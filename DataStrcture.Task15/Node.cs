using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrcture
{
    class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;

        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        public void SetValue(T value) { this.value = value; }
        public void SetNext(Node<T> next) { this.next = next; }
        public T GetValue() { return this.value; }
        public Node<T> GetNext() { return this.next; }
        public bool HasNext() { return this.next != null; }
        public override string ToString() { return this.value + "-->" + this.next; }

        public override bool Equals(object obj)
        {
            if (obj.GetHashCode() == this.GetHashCode())
                return true;
               

            if (obj is Node<T>)
                return ((Node<T>)obj).value.Equals(value);
            else
                return false;
        }

    }
}
