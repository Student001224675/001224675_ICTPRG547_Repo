using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }

        public Node(T data)
        {
            Data = data;
        }

    }
    
    
}
