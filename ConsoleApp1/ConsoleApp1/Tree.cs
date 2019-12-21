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

    class Tree
    {
        public int Root;

        public Tree()
        {

        }

        public void Add(int node)
        {
           
            Root = node;
           
        }
    }
}
