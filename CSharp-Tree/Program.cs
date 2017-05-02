using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tree
{
    class Program
    {
        public class Node
        {
            public static bool ValueIsInTree(Node Node, int SearchValue)
            {
                if (Node == null)
                {
                    Console.WriteLine("Something when wrong....");
                    Console.WriteLine($"Could not find Value ({SearchValue}) in Tree");
                    return false;
                }
                    
                if (Node.Value == SearchValue)
                {                    
                    Console.WriteLine($"Found (${SearchValue}) in tree");
                    return true;
                }

                if (Node.Value < SearchValue)
                {
                    Console.WriteLine($"CurrentValue ({Node.Value}) < Searched Value ({SearchValue})");
                    return ValueIsInTree(Node.Right, SearchValue);
                }

                if (Node.Value > SearchValue)
                {
                    Console.WriteLine($"CurrentValue ({Node.Value}) > Searched Value ({SearchValue}) ");
                    return ValueIsInTree(Node.Left, SearchValue);
                }

                Console.WriteLine("Something when wrong....");
                return false;
            }

            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int Value, Node Left = null, Node Right = null)
            {
                this.Value = Value;
                this.Left = Left;
                this.Right = Right;                
            }
        }
        
        static void Main(string[] args)
        {            
            var root = new Node(20,
                    new Node(8, 
                        new Node(4, null, null), 
                        new Node(12,
                            new Node(10, null, null),
                            new Node(14, null, null)
                        )
                    ),
                    new Node(22, null, null)                        
                );

            Node.ValueIsInTree(root, 14);


            Console.ReadKey();




        }
    }
}
