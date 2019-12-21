using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public enum Side
    {
        Left,
        Right
    }
    class Node
    {
        public int data;
        public Node(int _data)
        {
            data = _data;
            LeftNode = null;
            RightNode = null;
        }
        
        public Node LeftNode { get; set; }

        public Node RightNode { get; set; }

        public Node ParentNode { get; set; }

    }
}
