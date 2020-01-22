using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj15_2
{
    public class CustomList<T>      //CustomList為外部類別，用來表示鏈結串列
    {
        private class Node              //Node為內部類別，用來表示鏈結串列的節點
        {
            public Node(T t)        //Node類別的建構函式，用來將節點初始化
            {
                next = null;
                data = t;
            }
            private Node next;
            public Node Next        //Next屬性用來存取下一個節點
            {
                get { return next; }
                set { next = value; }
            }
            private T data;
            public T Data           //Data屬性用來存取節點的資料
            {
                get { return data; }
                set { data = value; }
            }
        }
        private Node head;
        public CustomList()         //CustomList類別的建構函式，用來將串列初始化
        {
            head = null;
        }
        public void Add(T t)        //Add() 方法用來插入新節點
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 10; i++)
                list.Add(i);
            foreach (int i in list)
                System.Console.Write(i + "  ");
            Console.ReadLine();
        }
    }
}
