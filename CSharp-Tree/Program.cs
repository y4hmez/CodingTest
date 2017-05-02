using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tree
{
    partial class Program
    {
        
        static void Main(string[] args)
        {            
            var root = new Node<int>(20,
                    new Node<int>(8, 
                        new Node<int>(4, null, null), 
                        new Node<int>(12,
                            new Node<int>(10, null, null),
                            new Node<int>(14, null, null)
                        )
                    ),
                    new Node<int>(22, null, null)                        
                );

            //Node<int>.ValueIsInTree(root, 14);
            var node = Node<int>.GetNodeWhile(root, 14);
            //GetNodeWhile
            Console.WriteLine(node.ToString());

            Console.ReadKey();




        }
    }
}
