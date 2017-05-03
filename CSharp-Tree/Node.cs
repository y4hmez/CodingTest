using System;
using System.Collections.Generic;

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

            public static void PreOrderTraversalNoRec(Node<T> root)
            {                
                var  stack = new Stack<Node<T>>();
                
                stack.Push(root);
                
                while(stack.Count > 0)
                {
                    var n = stack.Pop();
                    
                    Console.WriteLine($"node values {n.Value.ToString()}");
                    if (n.Right != null)
                        stack.Push(n.Right);

                    if (n.Left != null)
                        stack.Push(n.Left);                    
                }
            }

            public static void PreOrderTraversal(Node<T> root)
            {
                if (root == null) return;
                Console.WriteLine($"node values {root.Value.ToString()}");

                PreOrderTraversal(root?.Left);                
                PreOrderTraversal(root?.Right);
                
            }

            public static Node<T> FindLowestCommonAncestorWhile(Node<T> root, T left, T right)
            {              
                var cur = root;

                while (true)
                {
                    if (cur == null)
                        return null;
              
                    var leftCmp = left.CompareTo(cur.Value);
                    var rightCmp = right.CompareTo(cur.Value);

                    if (leftCmp < 0 && rightCmp < 0)
                    {
                        cur = cur.Left;
                        continue;
                    }

                    if (leftCmp > 0 && rightCmp > 0)
                    {
                        cur = cur.Left;
                        continue;
                    }

                    return cur;
                }
                
            }


            public static Node<T> FindLowestCommonAncestor(Node<T> root, T left, T right)
            {
                if (root == null)
                    return null;
                
                var leftCmp = left.CompareTo(root.Value);
                var rightCmp = right.CompareTo(root.Value);

                if (leftCmp < 0 && rightCmp < 0)
                {
                    return FindLowestCommonAncestor(root.Left, left, right);
                }

                if (leftCmp > 0 && rightCmp > 0)
                {
                    return FindLowestCommonAncestor(root.Right, left, right);
                }

                return root;
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
