﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesProblems
{
    public class Stacks
    {
        public Node top;
        public Stacks()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("Stack is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
