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
            tree.Add(2, tree.Root);
            Assert.AreEqual(tree.Root.data, 2);
            tree.Add(1, tree.Root);
            tree.Add(3, tree.Root);
        }
        [Test]
        public void CanSearchValue()
        {
            Tree tree = new Tree();
            tree.Add(20, tree.Root);

            tree.Add(10, tree.Root);
            tree.Add(30, tree.Root);
            tree.Add(1, tree.Root);
            tree.Add(38, tree.Root);

            Assert.AreEqual(true, tree.Search(38, tree.Root));
            Assert.AreEqual(true, tree.Search(1, tree.Root));
            Assert.AreEqual(false, tree.Search(47, tree.Root));
        }
    }
}
