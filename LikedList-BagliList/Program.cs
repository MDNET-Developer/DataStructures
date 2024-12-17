using System;
using System.Threading;
using System.Threading.Tasks;

namespace LikedList_BagliList
{
    internal class Program
    {
        public class Node
        {
            public int _data;
            public Node next;
            public Node(int data)
            {
                _data = data;
                next = null;
            }
        }

        public class NodeList
        {
            public Node head;
            public NodeList()
            {
                head = null;
            }

            public void Print()
            {
                Console.WriteLine();
               
                Node temp = head;
                if (head == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Empty List !!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.Write("Start -> ");

                    while (temp.next != null)
                    {
                        Console.Write(temp._data + " -> ");
                        temp = temp.next;
                    }
                    Console.Write(temp._data + " -> Finish");
                    Console.WriteLine();
                }
                     Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

            }
            public void deleteWithIndexNumber(int index)
            {
                int i = 0;
                if (head==null)
                {
                    Console.WriteLine("Empty list");
                }
                else if (head.next==null && index == 0)
                {
                    head = null;
                    Console.WriteLine("Last element deleted");
                }

                else
                {
                    Node temp = head;
                    Node temp2 = temp;
                    while (temp.next != null)
                    {
                        if (i == index)
                        {
                            temp2.next = temp.next;
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
            public void addWithIndexNumber(int index, int data)
            {
                int i = 0;
                Node element = new(data);
                if (index==0)
                {
                    addBegining(data);
                }
               
                else
                {
                    Node temp = head;
                    Node temp2 = temp;
                    while (temp.next != null)
                    {
                        if (i==index)
                        {
                            temp2.next = element;
                            element.next = temp;
                            i++;
                        }
                        temp2 = temp;
                        temp = temp.next;
                        i++;
                    }


                }
                if (i==index)
                {
                    addLast(data);
                }

                
                
            }
            public void deleteBegining()
            {
                if (head == null)
                {

                    Console.WriteLine($"Can not delete empty list");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Basadan bir element silindi - '{head._data}'");
                    head = head.next;

                }
            }
            public void addBegining(int data)
            {
                Node element = new Node(data);
                if (head == null)
                {
                    head = element;
                    Console.WriteLine($"List yaradildi ve ilk duyum elave olundu - '{element._data}'");
                }
                else
                {
                    element.next = head;
                    head = element;
                    Console.WriteLine($"Basa element elave olundu - '{element._data}'");
                }
            }
            public void addLast(int data)
            {
                Node element = new(data);
                if (head == null)
                {
                    head = element;
                    Console.WriteLine($"List yaradildi ve ilk duyum elave olundu - '{element._data}'");
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = element;
                    Console.WriteLine($"Sona element elave olundu - '{element._data}'");
                }
            }
            public void deleteLast()
            {
                if (head == null)
                {

                    Console.WriteLine($"Can not delete empty list");
                }
                else
                {
                    // 1 -> 2 ->  3 ->  4 ->  5 ->  6 ->  7 ->  null
                    /*
               ------------------------------------------------------------------------
                       head
                      [Düyün1] -> [Düyün2] -> [Düyün3] -> null
                        temp
                        temp2
               ------------------------------------------------------------------------
                       head
                      [Düyün1] -> [Düyün2] -> [Düyün3] -> null
                        temp2        temp
                        
               ------------------------------------------------------------------------
                     head
                    [Düyün1] -> [Düyün2] -> [Düyün3] -> null
                                  temp2       temp
               ------------------------------------------------------------------------
                   */

                    Node temp = head;
                    Node temp2 = temp;
                    while (temp.next != null)
                    {
                        temp2 = temp;
                        temp = temp.next;
                    }
                    temp2.next = null;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sondan bir element silindi");
                    if (head.next == null)
                    {
                        head = null;
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            NodeList nodeList = new();

            int eded;
            int indexNum;
            int secim = Menu();
            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("Eded daxil et:"); eded = int.Parse(Console.ReadLine());
                        nodeList.addBegining(eded);
                        break;
                    case 2:
                        Console.Write("Eded daxil et:"); eded = int.Parse(Console.ReadLine());
                        nodeList.addLast(eded);
                        break;
                    case 3:
                        nodeList.deleteBegining();
                        break;
                    case 4:
                        nodeList.deleteLast();
                        break;
                    case 5:
                        Console.Write("Index nomresi: "); indexNum = int.Parse(Console.ReadLine());
                        Console.Write("Eded daxil et:"); eded = int.Parse(Console.ReadLine());
                        nodeList.addLast(eded);
                        nodeList.addWithIndexNumber(indexNum,eded);
                        break;
                        case 6:
                        Console.Write("Index nomresi: "); indexNum = int.Parse(Console.ReadLine());
                        nodeList.deleteWithIndexNumber(indexNum);
                        break;
                    case 0:
                        break;
                        
                }
                nodeList.Print();
                secim = Menu();
            }
            Console.WriteLine();

            static int Menu()
            {
                int secim;
                Console.WriteLine("1 - basa elave et");
                Console.WriteLine("2 - sona elave et");
                Console.WriteLine("3 - basdan sil");
                Console.WriteLine("4 - soldan sil");
                Console.WriteLine("5 - ara hisseye element elave et");
                Console.WriteLine("6 - ara hisseden element sil");
                Console.WriteLine("0 - Proqrami bagla");
                Console.Write("Secim: ");
                secim = int.Parse(Console.ReadLine());
                return secim;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--- Application ended ---");
            var key = Console.ReadKey(intercept: true);
            if (key.Key == ConsoleKey.Escape)
                Environment.Exit(0);
           
        }
    }
}
