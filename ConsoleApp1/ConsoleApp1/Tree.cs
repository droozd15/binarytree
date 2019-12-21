using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        public Node Root;

        public Tree()
        {

        }

        public void Add(int data, Node curentNode)
        {

            if (Root == null)
            {
                Node node = new Node(data);
                Root = node;
                return;
            }
           
            if (curentNode.data < data)
            {
                if (curentNode.RightNode == null)
                    curentNode.RightNode = new Node(data);
                else
                    Add(data, curentNode.RightNode);
            }
            else if (curentNode.data > data)
            {
                if (curentNode.LeftNode == null)
                    curentNode.LeftNode = new Node(data);
                else
                    Add(data, curentNode.LeftNode);
            }
        }
    }
}
