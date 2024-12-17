using System;
using System.Drawing;

namespace LikedList_BagliList_IkiTerefli
{

    class Node
    {
        public int _data;
        public Node next;
        public Node previos;
        public Node(int data)
        {
            _data = data;
            next = null;
            previos = null;
        }
    }

    class NodeList
    {
        Node head;
        Node tail;
        public NodeList()
        {
            head = null;
            tail = null;
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Empty List !");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
            
                Console.WriteLine("________________________________________________________");
                Console.WriteLine();
                Node temp = head;
                Console.Write("Start -> ");
                while (temp.next != null)
                {
                    Console.Write(temp._data + " -> ");
                    temp = temp.next;
                }
                Console.Write(temp._data + " -> Finish");
                Console.WriteLine();
                Console.WriteLine("________________________________________________________");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void addWithIndexNumber(int index, int data)
        {
            Node element = new Node(data);
          
            if (head==null && index == 0)
            {
                head = tail = element;
            }
            else if (head!=null && index==0) 
            {
                addBegin(data);
            }
            else
            {
                Node temp = head;
                Node temp2 = temp;
                int i = 0;
                while (temp.next != null)
                {
                    if (i==index)
                    {
                        temp2.next = element;
                        element.previos = temp2;
                        element.next = temp;
                        temp.previos = element;
                        i++;

                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
            }
        }

        public void deleteWithIndexNumber(int index)
        {
            int i = 0;
            if (head==null)
            {
                Console.WriteLine("Empty List !");
            }
            else if (head.next==null && index==0)
            {
                head = tail = null;
                Console.WriteLine("Last element deleted !");
            }
            else
            {
                /* 1  2  3  4  5 */
             
                Node temp = head;
                Node temp2 = temp;
                while (temp.next!=null)
                {
                    if (i==index)
                    {
                        temp2.next = temp.next;
                        temp.next.previos = temp2;
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
            }

            if (i == index)
            {
                deleteLast();
            }
        }


        public void deleteBegin()
        {

            if (head == null)
            {
                Console.WriteLine("Empty list !");
            }
            else if(head.next==null)
            {
                head = tail = null;
                Console.WriteLine("Last element deleted");
            }
            else
            {
                head = head.next;
                head.previos = null;
                Console.WriteLine("Deleted item from begining");
            }
        }

        public void deleteLast()
        {

            if (head == null)
            {
                Console.WriteLine("Empty list !");
            }
            else if (head.next == null)
            {
                head = tail = null;
                Console.WriteLine("Last element deleted");
            }
            else
            {

                tail = tail.previos;
                tail.next = null;
                Console.WriteLine("Deleted last element");
            }
        }

        public void addBegin(int data)
        {
            Node element = new Node(data);
            if (head == null)
            {
                head = tail = element;
                Console.WriteLine("List created, and first element:" + data + "added");
            }
            else
            {
                element.next = head;
                head.previos = element;
                head = element;
            }
        }

        public void addLast(int data)
        {
            Node element = new Node(data);
            if (head == null)
            {
                head = tail = element;
                Console.WriteLine("List created, and first element:" + data + "added");
            }
            else
            {
                tail.next = element;
                element.previos = tail;
                tail = element;
                Console.WriteLine("Last data :" + data + "added");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NodeList doblyList = new NodeList();
            int element;
            int choice = Menu();
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Eded daxil et:");
                        element = int.Parse(Console.ReadLine());
                        doblyList.addBegin(element);
                        break;
                    case 2:
                        Console.Write("Eded daxil et:");
                        element = int.Parse(Console.ReadLine());
                        doblyList.addLast(element);
                        break;
                    case 3:
                       
                        doblyList.deleteBegin();
                        break;
                    case 4:
                       
                        doblyList.deleteLast();
                        break;
                    case 5:
                        Console.Write("Eded daxil et:");
                        element = int.Parse(Console.ReadLine());
                        Console.Write("Index daxil et:");
                        int index = int.Parse(Console.ReadLine());
                        doblyList.addWithIndexNumber(index,element);
                        break;

                    case 6:
                        Console.Write("Index daxil et:");
                        int i = int.Parse(Console.ReadLine());
                        doblyList.deleteWithIndexNumber(i);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Closed!");
                        
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                doblyList.Print();
                choice = Menu();
            }
        }


        public static int Menu()
        {
            Console.WriteLine("1 - basa elave et");
            Console.WriteLine("2 - sona elave et");
            Console.WriteLine("3 - basdan sil");
            Console.WriteLine("4 - sondan sil");
            Console.WriteLine("5 - ara hisseye element elave et");
            Console.WriteLine("6 - ara hisseden element sil");
            Console.WriteLine("0 - Proqrami bagla");
            Console.Write("Element: ");
            int element = int.Parse(Console.ReadLine());
            return element;
        }
    }


}
