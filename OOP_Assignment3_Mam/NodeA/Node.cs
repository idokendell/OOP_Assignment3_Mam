using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3_Mam.NodeA
{
    public class Node
    {
        private int _value;
        private Node _next;
        public Node(int value)
        {
            _value = value;
            _next=null;
        }
        public Node(int value, Node next)
        {
            _value=value;
            _next=next;
        }

        public void SetNext(Node other) { _next=other; }

        public int GetValue() { return _value; }
        public Node GetNext() { return _next; }
        public void SetValue(int num) { _value = num; }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (ReferenceEquals(obj, this))
                return false;

            if (obj.GetType() != GetType())
                return false;

            Node other = obj as Node;

            return _value == other._value
                && _next == other._next;

        }

    }
}

