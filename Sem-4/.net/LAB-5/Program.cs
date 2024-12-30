using System;
using System.Collections.Generic;
using System.Collections;
//using System.Collections.DictionaryEntry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace LAB_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArrayList s1 = new ArrayList();
            //// add 
            //s1.Add(1);
            //s1.Add(2);
            //s1.Add("namra");

            //foreach (object i in s1)
            //{
            //    Console.WriteLine(i);
            //}
            //// Remove 

            //s1.Remove(1);
            //foreach (object i in s1)
            //{
            //    Console.WriteLine(i);
            //}
            //s1.Add(1);
            //s1.Add(2);
            //s1.Add("namra");

            //// RemoveRange() - [2,"namra",1,2,"namra"]

            //s1.RemoveRange(2,3);
            //foreach (object i in s1)
            //{
            //    Console.WriteLine(i);
            //}

            ////clear 
            //s1.Clear();
            //foreach (object i in s1)
            //{
            //    Console.WriteLine(i);
            //}
            //List<String> l1 = new List<String>();

            ////        a.Add() - To Add new student in list
            //l1.Add("a");
            //l1.Add("B");
            //l1.Add("C");

            //foreach (object i in l1)
            //{
            //    Console.WriteLine(i);
            //}


            ////b.Remove() - To Remove Student with specified index
            //l1.Remove("a");

            //foreach (object i in l1)
            //{
            //    Console.WriteLine(i);
            //}

            ////c.RemoveRange() - To Remove student with specified range.
            //l1.Add("d");
            //l1.Add("f");
            //l1.RemoveRange(0, 1);
            //foreach (object i in l1)
            //{
            //    Console.WriteLine(i);
            //}

            ////d.Clear() - To clear all the student from the list
            //l1.Clear();

            //Stack stack = new Stack();
            ////a.Push() - To Add new item in stack
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);  
            //stack.Push(6);
            //stack.Push(7);
            //stack.Push(8);
            //stack.Push(9);

            //foreach (object o in stack)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("-----------------------------------POP");    
            ////b.Pop() - To Remove item from the stack
            //stack.Pop();
            //foreach (object o in stack)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("-----------------------------------Peek");
            ////c.Peek() – To Return the top item from the stack. 
            ////int a = convert.int32(stack.Peek());
            //stack.Peek();
            //foreach (object o in stack)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("-----------------------------------contains");
            ////d.Contains() - To Checks whether an item exists in the stack or not. 
            // Boolean  a =  stack.Contains(5);
            ////foreach (object o in stack)
            ////{
            ////    Console.WriteLine(o);
            ////}
            //Console.WriteLine(a);
            //Console.WriteLine("-----------------------------------");
            ////e.Clear() - To clear items from stack
            //stack.Clear();

            //Create a Queue which takes integer values and perform following
            //operations:

            //   Queue<int> q = new Queue<int> ();

            ////            a.Enqueue() - Adds an item into the queue.
            //Console.WriteLine("-------enqueue");
            //q.Enqueue (1);
            //q.Enqueue (2);  
            //q.Enqueue (3);  
            //q.Enqueue (4);  
            //q.Enqueue (5);
            //q.Enqueue (6);
            //q.Enqueue (7);
            //q.Enqueue (8);
            //q.Enqueue (9);
            //q.Enqueue (10);
            //foreach (object o in q) {
            //    Console.WriteLine(o);
            //}


            ////            b.Dequeue() - Returns an item from the beginning of the queue and
            ////                                      removes it from the queue. 
            //Console.WriteLine("-------dequeue");
            //q.Dequeue ();
            // foreach (object o in q)
            //{
            //    Console.WriteLine(o);
            //}

            ////c.Peek() - Returns an first item from the queue without removing it.
            //Console.WriteLine("-----------------Peek");
            //int a = q.Peek ();
            //Console.WriteLine(a);
            ////d.Contains() - Checks whether an item is in the queue or not
            //Console.WriteLine("-----------------contains");
            //Boolean b1 = q.Contains(2);
            //Console.WriteLine(b1);
            ////e.Clear() - Removes all the items from the queue
            //Console.WriteLine("------------------------clear");
            //q.Clear();

            //Create a Dictionary collection class object and preform following
            //operations: 
            //Dictionary<int, string> d1 = new Dictionary<int, string>();

            ////a.Add: Adds a key-value pair.
            //d1[1] = "jay";
            //d1[2] = "namra";
            //d1[3] = "dhol";

            //foreach (object o in d1)
            //{
            //    Console.WriteLine(o);
            //}


            ////b.Remove: Removes a key-value pair by key.
            //Console.WriteLine("---------------Remove");
            //d1.Remove(1);
            //foreach (object o in d1)
            //{
            //    Console.WriteLine(o);
            //}
            ////c.ContainsKey: Checks if a key exists in the hashtable. 
            //Console.WriteLine("'--------------------contains/key'");
            //Boolean b1 = d1.ContainsKey(2);
            //Console.WriteLine(b1);
            ////d.ContainsValue: Checks if a value exists in the hashtable. 
            //Console.WriteLine("--------------------------containsvaliue");
            //Boolean c = d1.ContainsValue("namra");
            //Console.WriteLine(c);
            ////e.Clear: Removes all key-value pairs. .
            //d1.Clear();


            //Create a Hashtable collection class object and preform following
            //operations: 

             Hashtable d1 = new Hashtable();

            d1[1] = "jay";
            d1[2] = "namra";
            d1[3] = "dhol";

            foreach (object o in d1.Values)
            {
                Console.WriteLine(o);
            }
            //b.Remove: Removes a key-value pair by key. 
            Console.WriteLine("---------------Remove");
            d1.Remove(1);
            foreach (object o in d1.Keys)
            {
                Console.WriteLine(o);
            }
            //c.ContainsKey: Checks if a key exists in the hashtable.

            Console.WriteLine("'--------------------contains/key'");
            Boolean b1 = d1.ContainsKey(2);
            Console.WriteLine(b1);


            //d.ContainsValue: Checks if a value exists in the hashtable. 
            Console.WriteLine("--------------------------containsvaliue");
            Boolean c = d1.ContainsValue("namra");
            Console.WriteLine(c);
            //e.Clear: Removes all key-value pairs. 

        }
    }
}
