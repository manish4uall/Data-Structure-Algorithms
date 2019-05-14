using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedListInt = new LinkedList<int>();
            linkedListInt.AddAtFront(new Node<int>(1));
            linkedListInt.AddAtFront(new Node<int>(2));
            linkedListInt.AddAtFront(new Node<int>(3));
            linkedListInt.AddAtEnd(new Node<int>(4));
            linkedListInt.AddAtFront(new Node<int>(5));
            linkedListInt.RemoveAtFront();
            linkedListInt.Print();

            Console.WriteLine("\n FirstNode: {0}, LastNode : {1}", linkedListInt.First.data, linkedListInt.Last.data);

            //LinkedList<string>  linkedListString= new LinkedList<string>();
            //linkedListString.AddAtFront(new Node<string>("Manish"));
            //linkedListString.AddAtFront(new Node<string>("Varun"));
            //linkedListString.AddAtFront(new Node<string>("Tarun"));
            //linkedListString.Print();

            //LinkedListNode<int> node = new LinkedListNode<int>(1);
            //System.Collections.Generic.LinkedList<int> list = new System.Collections.Generic.LinkedList<int>();
            //list.AddFirst(node);
            //Console.WriteLine(list.Count());
            Console.Read();
        }
    }

    class LinkedList<T>
    {
        public Node<T> First { get; private set; } = null;

        private Node<T> _last = null;
        public Node<T> Last { get { return _last; } }

        public void AddAtFront(Node<T> node)
        {
            if (First == null)
            {
                _last = node;
                First = node;
            }
            else
            {
                node.nextNode = First;
                First = node;
            }
        }

        public void AddAtEnd(Node<T> node)
        {
            if (_last == null)
            {
                _last = node;
                First = node;
            }
            else
            {
                _last.nextNode = node;
                _last = node;
            }
        }

        // Insert before a node with data 5
        public void AddInBetween()
        {

        }

        public void MoveLastNodeToFront()
        {

        }

        public void FindValueOfMiddleNode()
        {


        }

        public void ReverseLinkedList()
        {

        }
        
        public void FindCycleInLinkedList()
        {

        }

        public void DoMergeSort()
        {

        }

        public void doBinarySearchOnSortedLinkedList()
        {

        }

        public void RemoveAtFront()
        {
            var temp = First.nextNode;
            First.nextNode = null;
            First = temp;
        }

        public void RemoveByValue(Node<T> value)
        {
            var traverse = First;
            Node<T> last_node = null;
            while (traverse != null)
            {
                if (traverse == null) { break; }

                if (traverse.data.Equals(value.data))
                {
                    if (last_node == null)
                    {
                        RemoveAtFront();
                    }
                    else if (traverse.nextNode == null)
                    {

                    }
                }
                last_node = traverse;
                traverse = traverse.nextNode;
            }
        }

        public void Print()
        {
            var x = First;
            while (x != null)
            {
                Console.Write(x.data);
                if (x.nextNode != null)
                {
                    Console.Write("-->");
                }
                x = x.nextNode;
            }

        }
    }

    class Node<T>
    {
        public T data;
        public Node<T> nextNode;
        public Node<T> prevNode;

        public Node(T value)
        {
            this.data = value;
        }
    }

    class DoubleLinkedList<T>
    {
        public void AddAtEnd() { }

        public void RemoveByValue(Node<T> value)
        {
        }

        // Insert before a node with data 5
        public void AddInBetween()
        {

        }
    }

}


