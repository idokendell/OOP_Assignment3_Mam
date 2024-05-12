using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3_Mam.NodeA
{
    public class LinkedList
    {
        public Node _node;
        private Node _last;
        private Node _max;
        private Node _min;
        public LinkedList(Node node)
        {
            _node=node;
            FindLast();
            FindMax();
            FindMin();
        }
        public LinkedList()
        {

        }
        private void FindLast()
        {
            _last=_node;
            while (_last.GetNext()!=null)
            {
                _last=_last.GetNext();
            }
        }
        public void Append(int num)
        {
            Node newn = new Node(num);
            if (_node==null)//list is empty
            {
                _node=newn;
                _last=_node;
                _min=_node;
                _max=_node;
            }
            else
            {
                if (num<_min.GetValue()) { _min=newn; }
                else if (num>_max.GetValue()) { _max=newn; }
                _last.SetNext(newn);
                _last=_last.GetNext();
            }
        }
        public void Prepend(int num)
        {
            Node temp = new Node(num, _node);
            if (num<_min.GetValue()) { _min=temp; }
            else if (num>_max.GetValue()) { _max=temp; }
            _node=temp;
        }
        public int Pop()
        {
            if (_node==null) return -1;
            int numPop = 0;
            Node follow = _node;
            if (follow.GetNext()==null)
            {
                numPop=follow.GetValue();
                _node=null;
            }
            else
            {
                while (follow.GetNext().GetNext()!=null)
                {
                    follow=follow.GetNext();
                }
                numPop = follow.GetNext().GetValue();
            }
            follow.SetNext(null);
            if (_last==_min) FindMin();
            if (_last==_max) FindMax();
            _last=follow;
            return numPop;
        }
        public int Unqueue()
        {
            if (_node==null) return -1;
            Node follow = _node;
            int numPop = _node.GetValue();
            _node=_node.GetNext();
            if (follow==_min) FindMin();
            if (follow==_max) FindMax();

            return numPop;

        }
        public IEnumerable<int> ToList()
        {
            Node follow = _node;
            List<int> list = new List<int>();
            while (follow!=null)
            {
                list.Add(follow.GetValue());
                follow=follow.GetNext();
            }
            return list;
        }
        public bool IsCircular()
        {
            if (_node==null) return true;
            Node follow = _node;
            while (follow.GetNext()!=null)
            {
                follow=follow.GetNext();
                if (follow ==_node) return true;
            }
            return false;
        }

        public Node GetMaxNode()
        {
            if (_node==null) return new Node(0);
            return _max;
        }
        public Node GetMinNode()
        {
            if (_node==null) return new Node(0);
            return _min;
        }
        public void Sort()
        {
            List<int> sortedList = ToList().OrderBy(x => x).ToList();
            //way without making a new linkedlist
            Node follow = _node;
            //**length linkedlist equals length sorted list**//
            foreach (int x in sortedList)
            {
                follow.SetValue(x);
                follow=follow.GetNext();
            }
            //another way
            //Node sorted = new Node(0);
            //Node follow = sorted;
            //sortedList.ForEach(x =>
            //{
            //    follow.SetNext(new Node(x));
            //    follow=follow.GetNext();
            //});
            //_node=sorted.GetNext();

        }
        private void FindMin()
        {
            if (_node==null) _min=null;
            else
            {
                Node follow = _node.GetNext();
                Node min = _node;
                while (follow!=null)
                {
                    if (min.GetValue()>follow.GetValue())
                    {
                        min=follow;
                    }
                    follow=follow.GetNext();
                }
                _min=min;
            }
        }
        private void FindMax()
        {
            if (_node==null) _max=null;
            else
            {
                Node follow = _node.GetNext();
                Node max = _node;
                while (follow!=null)
                {
                    if (max.GetValue()<follow.GetValue())
                    {
                        max=follow;
                    }
                    follow=follow.GetNext();
                }
                _max=max;
            }
        }
        public override string ToString()
        {
            Node follow = _node;
            if (_node==null) return "node empty";
            string newstring = ""+follow.GetValue();
            while (follow.GetNext()!=null)
            {
                follow=follow.GetNext();
                newstring+= "-->"+follow.GetValue();
            }
            return newstring;
        }
    }
}
