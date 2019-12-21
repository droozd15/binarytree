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

        public void Add(int data)
        {

            if (Root == null)
            {
                Node node = new Node(data);
                Root = node;
            }
           
        }
    }
}
