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
                {
                    curentNode.RightNode = new Node(data);
                    curentNode.RightNode.ParentNode = curentNode;
                }
                else
                    Add(data, curentNode.RightNode);
            }
            else if (curentNode.data > data)
            {
                if (curentNode.LeftNode == null)
                {
                    curentNode.LeftNode = new Node(data);
                    curentNode.LeftNode.ParentNode = curentNode;
                }
                else
                    Add(data, curentNode.LeftNode);
            }
        }

        public bool Search(int data, Node curentNode)
        {
            if (curentNode == null)
                return false;
            if (curentNode.data == data)
                return true;
            else if (curentNode.data > data)
                return Search(data, curentNode.LeftNode);
            else if (curentNode.data < data)
                return Search(data, curentNode.RightNode);
            return false;
        }
        public Node Next (Node currentNode)
        {
            return SearchMin(currentNode.RightNode);
        }
        public Node SearchMin(Node currentNode)
        {
            if (currentNode == null)
                return null;
            if (currentNode.LeftNode == null)
                return currentNode;
            else return SearchMin(currentNode.LeftNode);
        }
        public bool Delete (int data, Node currentNode)
        {
            if (currentNode == null)
                return false;
            if (currentNode.data == data) 
            {
                if (currentNode.LeftNode == null && currentNode.RightNode == null) 
                {
                    if (currentNode.ParentNode.data > currentNode.data)
                        currentNode.ParentNode.LeftNode = null;
                    else
                        currentNode.ParentNode.RightNode = null;
                    return true;
                } else if (currentNode.LeftNode == null)
                {
                    if (currentNode.ParentNode.data > currentNode.data)
                        currentNode.ParentNode.LeftNode = currentNode.RightNode;
                    else
                        currentNode.ParentNode.RightNode = currentNode.RightNode;
                    return true;
                }
                else if (currentNode.RightNode == null)
                {
                    if (currentNode.ParentNode.data > currentNode.data)
                        currentNode.ParentNode.LeftNode = currentNode.LeftNode;
                    else
                        currentNode.ParentNode.RightNode = currentNode.LeftNode;
                    return true;
                } else
                {
                    currentNode = Next(currentNode);
                }

                return true;
            }
            if (currentNode.data > data) 
                return Delete(data, currentNode.LeftNode);
            else
                return Delete(data, currentNode.RightNode);
            
        }
    }
}
