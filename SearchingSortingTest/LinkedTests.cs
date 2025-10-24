using NUnit.Framework;
using System;
using Nathan_ICTPRG547_Assignment;

namespace SearchingSortingTest
{
    [TestFixture]
    public class LinkedTests
    {
        private SinglyLinkedList<Student> list;
        private Student[] students;

        [SetUp]
        public void SetUp() 
        {
            list = new SinglyLinkedList<Student>();
            students = new Student[]
            {
                new Student("S001","IT","15/1/2025"),
                new Student("S002","IT","16/1/2025"),
                new Student("S003","IT","17/1/2025"),
                new Student("S004","IT","18/1/2025"),
                new Student("S005","IT","19/1/2025"),
                new Student("S006","IT","20/1/2025"),
                new Student("S007","IT","21/1/2025"),
                new Student("S008","IT","22/1/2025"),
                new Student("S009","IT","23/1/2025"),
                new Student("S010","IT","24/1/2025")
            };
        }

        [Test]
        public void HeadTest()
        {
            list.AddFirst(students[1]);
            list.AddFirst(students[0]);

            Assert.AreEqual(list.Head.Value, students[0]);
        }

        [Test]
        public void TailTest()
        {
            list.AddLast(students[8]);
            list.AddLast(students[9]);

            Assert.AreEqual(list.Tail.Value, students[9]);
        }

        [Test]
        public void FindTest()
        {
            foreach (var student in students)
            {
                list.Add(student);
            }
            Assert.IsTrue(list.Contains(students[5]));
        }

        [Test]
        public void RemoveFirstTest()
        {
            foreach (var student in students)
            {
                list.AddLast(student);
            }
     
            list.RemoveFirst();

            Assert.IsFalse(list.Contains(students[0]));
        }

        [Test]
        public void RemoveLastTest()
        {
            foreach (var student in students)
            {
                list.AddLast(student);
            }
            list.RemoveLast();

            Assert.IsFalse(list.Contains(students[9]));
        }
    }

    [TestFixture]
    public class DoublyLinkedListTests
    {
        private DoublyLinkedList<Student> list;
        private Student[] students;
        [SetUp]
        public void SetUp()
        {
            list = new DoublyLinkedList<Student>();
            students = new Student[]
            {
                new Student("S001","IT","15/1/2025"),
                new Student("S002","IT","16/1/2025"),
                new Student("S003","IT","17/1/2025"),
                new Student("S004","IT","18/1/2025"),
                new Student("S005","IT","19/1/2025"),
                new Student("S006","IT","20/1/2025"),
                new Student("S007","IT","21/1/2025"),
                new Student("S008","IT","22/1/2025"),
                new Student("S009","IT","23/1/2025"),
                new Student("S010","IT","24/1/2025")
            };
        }

        [Test]
        public void HeadTest()
        {
            list.AddFirst(students[1]);
            list.AddFirst(students[0]);
            Assert.AreEqual(list.Head.Value, students[0]);
        }

        [Test]
        public void TailTest()
        {
            list.AddLast(students[8]);
            list.AddLast(students[9]);
            Assert.AreEqual(list.Tail.Value, students[9]);
        }

        [Test]
        public void FindTest()
        {
            foreach (var student in students)
            {
                list.Add(student);
            }
            Assert.IsTrue(list.Contains(students[5]));
        }

        [Test]
        public void RemoveFirstTest()
        {
            foreach (var student in students)
            {
                list.AddLast(student);
            }

            list.RemoveFirst();

            Assert.IsFalse(list.Contains(students[0]));
        }

        [Test]
        public void RemoveLastTest()
        {
            foreach (var student in students)
            {
                list.AddLast(student);
            }
            list.RemoveLast();

            Assert.IsFalse(list.Contains(students[9]));
        }
    }

    [TestFixture]
    public class BinaryTreeTests
    {
        private BinaryTree tree;
        private Student[] students;
        [SetUp]
        public void SetUp()
        {
            tree = new BinaryTree();
            students = new Student[]
            {
                new Student("S001","IT","15/1/2025"),
                new Student("S002","IT","16/1/2025"),
                new Student("S003","IT","17/1/2025"),
                new Student("S004","IT","18/1/2025"),
                new Student("S005","IT","19/1/2025"),
                new Student("S006","IT","20/1/2025"),
                new Student("S007","IT","21/1/2025"),
                new Student("S008","IT","22/1/2025"),
                new Student("S009","IT","23/1/2025"),
                new Student("S010","IT","24/1/2025")
            };

            foreach (var student in students)
            {
                var key = int.Parse(student.StudentID.Substring(1));
                tree.Add(key);
            }
        }

        [Test]
        public void PreOrderTest()
        {
            var sw = new StringWriter();
            var original = Console.Out;
            Console.SetOut(sw);
            tree.TraversePreOrder(tree.Root);
            Console.SetOut(original);

            var tokens = sw.ToString().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var actual = string.Join(" ", tokens);
            var expected = "1 2 3 4 5 6 7 8 9 10";

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InOrderTest()
        {
            var sw = new StringWriter();
            var original = Console.Out;
            Console.SetOut(sw);

            tree.TraverseInOrder(tree.Root);

            Console.SetOut(original);
            var tokens = sw.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var actual = string.Join(" ", tokens);

            var expected = "1 2 3 4 5 6 7 8 9 10";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostOrderTest()
        {
            var sw = new StringWriter();
            var original = Console.Out;
            Console.SetOut(sw);

            tree.TraversePostOrder(tree.Root);

            Console.SetOut(original);
            var tokens = sw.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var actual = string.Join(" ", tokens);

            var expected = "10 9 8 7 6 5 4 3 2 1";
            Assert.AreEqual(expected, actual);
        }
    }
}
