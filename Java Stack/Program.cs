using System;
using System.Collections;

namespace Java_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != null & input !="")
            {
                if (ParenthesesBalanced(input))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        static bool ParenthesesBalanced(string input)
        {
            Stack stack = new();
            bool balance = true;

            foreach (char elemento in input)
            {
                if (elemento == '{' || elemento == '(' || elemento == '[')
                {
                    stack.Push(elemento);
                }
                else
                {
                    if(stack.Count > 0)
                    {
                        if (elemento == '}')
                        {
                            if (Convert.ToChar(stack.Peek()) == '{')
                            {
                                stack.Pop();
                            }
                        }

                        if (elemento == ')')
                        {
                            if (Convert.ToChar(stack.Peek()) == '(')
                            {
                                stack.Pop();
                            }
                        }

                        if (elemento == ']')
                        {
                            if (Convert.ToChar(stack.Peek()) == '[')
                            {
                                stack.Pop();
                            }
                        }
                    }
                    else
                    {
                        balance = false;
                    }
                    
                }
            }

            return stack.Count == 0 && balance;
        }
    }
}
