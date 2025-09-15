using NUnit.Framework;
using System;
using Nathan_ICTPRG547_Assignment;

namespace SearchingSortingTest
{
    [TestFixture]
    public class Tests
    {
        private Student[] student;
        [SetUp]
        public void Setup()
        {
            student = new Student[]
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
        public void Test1()
        {
            Assert.That(Utility.LinearSearchArray<Student>(student, new Student("S004", "IT", "18/1/2025")) == 3);
        }

        [Test]
        public void Test2()
        {
            Assert.That(Utility.LinearSearchArray<Student>(student, new Student("S011", "IT", "18/1/2025")) == -1);
        }

        [Test]
        public void Test3()
        {
            Assert.That(Utility.BinarySearchArray<Student>(student, new Student("S007", "IT", "18/1/2025")) == 6);
        }

        [Test]
        public void Test4()
        {
            Assert.That(Utility.BinarySearchArray<Student>(student, new Student("S000", "IT", "18/1/2025")) == -1);
        }

        [Test]
        public void Test5()
        {
            Student[] unsortedStudent = new Student[]
            {
                new Student("S005","IT","19/1/2025"),
                new Student("S003","IT","17/1/2025"),
                new Student("S001","IT","15/1/2025"),
                new Student("S004","IT","18/1/2025"),
                new Student("S002","IT","16/1/2025")
            };
            Utility.BubbleSortOfArrayInAscending<Student>(unsortedStudent);
            Assert.That(unsortedStudent[0].StudentID == "S001");
            Assert.That(unsortedStudent[1].StudentID == "S002");
            Assert.That(unsortedStudent[2].StudentID == "S003");
            Assert.That(unsortedStudent[3].StudentID == "S004");
            Assert.That(unsortedStudent[4].StudentID == "S005");
        }

        [Test]
        public void Test6()
        {
            Student[] unsortedStudent = new Student[]
            {
                new Student("S003","IT","17/1/2025"),
                new Student("S001","IT","15/1/2025"),
                new Student("S005","IT","19/1/2025"),
                new Student("S004","IT","18/1/2025"),
                new Student("S002","IT","16/1/2025")
            };
            Utility.BubbleSortOfArrayInDescending<Student>(unsortedStudent);
            Assert.That(unsortedStudent[0].StudentID == "S005");
            Assert.That(unsortedStudent[1].StudentID == "S004");
            Assert.That(unsortedStudent[2].StudentID == "S003");
            Assert.That(unsortedStudent[3].StudentID == "S002");
            Assert.That(unsortedStudent[4].StudentID == "S001");
        }
        
    }
}