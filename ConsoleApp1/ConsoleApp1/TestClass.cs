using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void CanCreateTree()
        {
            Tree tree = new Tree();
            Assert.NotNull(tree);
        }

        [Test]
        public void CanAddValue()
        {
            Tree tree = new Tree();
            tree.Add(2);
            Assert.AreEqual(tree.Root.data, 2);
        }
    }
}
