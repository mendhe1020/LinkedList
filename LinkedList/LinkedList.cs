using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)                     
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        // Add method for Reverse the order of created Linked List
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        // Method create "Append"
        public void Appending(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }
        // Method create "InsertAtParticularPosition"
        internal Node InsertAtParticularPosition(int Position, int data)
        {
            Node node = new Node(data);
            if (Position < 1)
            {
                Console.WriteLine("Invalid Position");

            }
            else if (Position == 1)
            {
                node.next = this.head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (Position > 2)
                {
                    temp = temp.next;
                    Position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
            return node;
        }
        // Adding method for Display
        internal void Display()                         
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
