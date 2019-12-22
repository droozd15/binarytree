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
        [Test]
        public void CanDeleteRightList()
        {
            Tree tree = new Tree();
            tree.Add(20, tree.Root);

            tree.Add(15, tree.Root);
            tree.Add(30, tree.Root);
            tree.Add(10, tree.Root);
            tree.Add(50, tree.Root);
            tree.Add(16, tree.Root);
            tree.Add(49, tree.Root);
            tree.Add(18, tree.Root);
            tree.Add(38, tree.Root);
            tree.Add(24, tree.Root);

         //   tree.Delete(24, tree.Root);
            tree.Delete(18, tree.Root);
          //  Assert.AreEqual(false, tree.Search(24, tree.Root));
            Assert.AreEqual(false, tree.Search(18, tree.Root));
        }
        [Test]
        public void CanDeleteLeftList()
        {
            Tree tree = new Tree();
            tree.Add(20, tree.Root);

            tree.Add(15, tree.Root);
            tree.Add(30, tree.Root);
            tree.Add(10, tree.Root);
            tree.Add(50, tree.Root);
            tree.Add(16, tree.Root);
            tree.Add(49, tree.Root);
            tree.Add(18, tree.Root);
            tree.Add(38, tree.Root);
            tree.Add(24, tree.Root);

            //   tree.Delete(24, tree.Root);
            tree.Delete(10, tree.Root);
            //  Assert.AreEqual(false, tree.Search(24, tree.Root));
            Assert.AreEqual(false, tree.Search(10, tree.Root));
        }

        [Test]
        public void CanDeleteNodeWithOneList()
        {
            Tree tree = new Tree();
            tree.Add(20, tree.Root);

            tree.Add(15, tree.Root);
            tree.Add(30, tree.Root);
            tree.Add(10, tree.Root);
            tree.Add(50, tree.Root);
            tree.Add(16, tree.Root);
            tree.Add(49, tree.Root);
            tree.Add(18, tree.Root);
            tree.Add(38, tree.Root);
            tree.Add(11, tree.Root);
            //tree.Add(36, tree.Root);

            tree.Delete(30, tree.Root);
            Assert.AreEqual(false, tree.Search(30, tree.Root));
            tree.Delete(49, tree.Root);
            Assert.AreEqual(false, tree.Search(49, tree.Root));
            tree.Delete(10, tree.Root);
            Assert.AreEqual(false, tree.Search(10, tree.Root));
            tree.Delete(50, tree.Root);
            Assert.AreEqual(false, tree.Search(50, tree.Root));
        }
        [Test]
        public void CanDeleteNodeWithTwoLists()
        {
            Tree tree = new Tree();
            tree.Add(20, tree.Root);

            tree.Add(15, tree.Root);
            tree.Add(30, tree.Root);
            tree.Add(10, tree.Root);
            tree.Add(50, tree.Root);
            tree.Add(16, tree.Root);
            tree.Add(49, tree.Root);
            tree.Add(18, tree.Root);
            tree.Add(38, tree.Root);
            tree.Add(24, tree.Root);
            tree.Delete(30, tree.Root);
            Assert.AreEqual(false, tree.Search(30, tree.Root));
            tree.Delete(15, tree.Root);
            Assert.AreEqual(false, tree.Search(15, tree.Root));
        }
        [Test]
        public void CanDeleteNodeFail()
        {
            Tree tree = new Tree();
            tree.Add(20, tree.Root);

            tree.Add(15, tree.Root);
            tree.Add(30, tree.Root);
            //    tree.Add(10, tree.Root);
            tree.Add(50, tree.Root);
            tree.Add(16, tree.Root);
            tree.Add(49, tree.Root);
            tree.Add(18, tree.Root);
            tree.Add(38, tree.Root);
            tree.Add(24, tree.Root);
            tree.Delete(37, tree.Root);
           // Assert.AreEqual(false, tree.Search(37, tree.Root));
        }

    }

}
