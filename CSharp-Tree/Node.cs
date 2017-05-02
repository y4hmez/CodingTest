using System;

namespace CSharp_Tree
{
    partial class Program
    {
        public class Node<T> where T : IComparable<T>, IEquatable<T>
        {
            
            public static bool ValueIsInTree(Node<T> Node, T SearchValue)
            {
                if (Node == null)
                {
                    Console.WriteLine("Something when wrong....");
                    Console.WriteLine($"Could not find Value ({SearchValue}) in Tree");
                    return false;
                }

                var compareResult = Node.Value.CompareTo(SearchValue);

                if (compareResult == 0)
                {                    
                    Console.WriteLine($"Found (${SearchValue}) in tree");
                    return true;
                }

                if (compareResult < 0)
                {
                    Console.WriteLine($"CurrentValue ({Node.Value}) < Searched Value ({SearchValue})");
                    return ValueIsInTree(Node.Right, SearchValue);
                }

                if (compareResult > 0)
                {
                    Console.WriteLine($"CurrentValue ({Node.Value}) > Searched Value ({SearchValue}) ");
                    return ValueIsInTree(Node.Left, SearchValue);
                }

                Console.WriteLine("Something when wrong....");
                return false;
            }

            public static Node<T> GetNodeWhile(Node<T> Node, T SearchValue)
            {
                while (Node != null)
                {   
                    var cmpreRslt = Node.Value.CompareTo(SearchValue);

                    if (cmpreRslt == 0) break;                    
                    if (cmpreRslt < 0)
                    {
                        Node = Node.Right;
                    }
                    else if (cmpreRslt > 0)
                    {
                        Node = Node.Left;
                    }                    
                }

                return Node;

            }


            public static Node<T> GetNodeInTree(Node<T> Node, T SearchValue)
            {
                if (Node == null)
                {
                    Console.WriteLine("Something when wrong....");
                    Console.WriteLine($"Could not find Value ({SearchValue}) in Tree");
                    return null;
                }

                int compareResult = Node.Value.CompareTo(SearchValue);

                if (compareResult == 0)
                {
                    Console.WriteLine($"Found (${SearchValue}) in tree");
                    return Node;
                }

                if (compareResult < 0)
                {
                    Console.WriteLine($"CurrentValue ({Node.Value}) < Searched Value ({SearchValue})");
                    return GetNodeInTree(Node.Right, SearchValue);
                }

                if (compareResult > 0)
                {
                    Console.WriteLine($"CurrentValue ({Node.Value}) > Searched Value ({SearchValue}) ");
                    return GetNodeInTree(Node.Left, SearchValue);
                }

                return null;
            }

            public T Value { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }

            public Node(T Value, Node<T> Left = null, Node<T> Right = null)
            {
                this.Value = Value;
                this.Left = Left;
                this.Right = Right;                
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
