using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public class Node<T>
        {
            private T data;
            private Node<T> next;

            public Node(T value)
            {
                this.data = value;
                this.next = null;
            }

            public T Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node<T> Next
            {
                get { return next; }
                set {  next = value; }
            }
        }

        public class Linkedlist<T>
        {
            private Node<T> head;

            public Linkedlist()
            {
                this.head = null;
            }

            public void AddFirst(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = head;
                head = newNode;
            }

            public void AddLast(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (head == null)
                {
                    head = newNode;
                    return;
                }

                Node<T> currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        

            public void traverse()
            {
                Node<T> currentNode = head;
                while (currentNode != null)
                {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
                }
            }       

            public bool Remove(T target)
            {
                Node<T> current = head;
                Node<T> previous = null;

                while (current != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.Data, target))
                    {
                        if (previous == null)
                            head = current.Next;
                        else
                            previous.Next = current.Next;

                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }

                return false;
            }

            // Đếm số phần tử trong danh sách
            public int Count()
            {
                int count = 0;
                Node<T> current = head;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }

            // Kiểm tra danh sách có rỗng không
            public bool IsEmpty()
            {
                return head == null;
            }

            // Xóa toàn bộ danh sách
            public void Clear()
            {
                head = null;
            }

            public Node<T> GetHead()
            {
                return head;
            }


        }
    }
}
    