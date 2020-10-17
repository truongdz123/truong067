using System;
using System.Security.Cryptography.X509Certificates;
namespace BaiTH3
{
    class Stack
    {
        private int top;
        private int[] s;
        public Stack()
        {
            top = -1;
            s = new int[20];
        }
        public Stack(int n)
        {
            top = -1;
            s = new int[n];
        }
        public bool empty()
        {
            return top == -1;
        }
        public bool full()
        {
            return top == s.Length - 1;
        }
        public void push(int x)
        {
            if (full())
                Console.WriteLine("stack day");
            else
                s[++top] = x;
        }
        public int pop()
        {
            if (empty()) throw new Exception("stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
        class app
        {
            static void Main(string[] args)
            {
                Stack s = new Stack();
                s.push(3);
                s.push(3);
                s.push(4);
                s.pop();
                while (!s.empty())
                    Console.Write(s.pop());
                Console.ReadKey();
            }
        }
    }
}
