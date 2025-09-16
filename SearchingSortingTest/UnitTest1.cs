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
            // linear search for student with ID S004
            Assert.That(Utility.LinearSearchArray<Student>(student, new Student("S004", "IT", "20/1/2025")) == 3);
        }

        [Test]
        public void Test2()
        {
            // linear search for non existent student with ID S011
            Assert.That(Utility.LinearSearchArray<Student>(student, new Student("S011", "IT", "18/1/2025")) == -1);
        }

        [Test]
        public void Test3()
        {
            // binary search for student with ID S007
            Assert.That(Utility.BinarySearchArray<Student>(student, new Student("S007", "IT", "18/1/2025")) == 6);
        }

        [Test]
        public void Test4()
        {
            // binary search for non existent student with ID S000
            Assert.That(Utility.BinarySearchArray<Student>(student, new Student("S000", "IT", "18/1/2025")) == -1);
        }

        [Test]
        public void Test5()
        {
            // bubble sort an unsorted array of students in ascending order
            Student[] unsortedStudent = new Student[]
            {
                new Student("S005","IT","19/1/2025"),
                new Student("S003","IT","17/1/2025"),
                new Student("S001","IT","15/1/2025"),
                new Student("S004","IT","18/1/2025"),
                new Student("S002","IT","16/1/2025"),
                new Student("S006","IT","20/1/2025"),
                new Student("S010","IT","24/1/2025"),
                new Student("S008","IT","22/1/2025"),
                new Student("S009","IT","23/1/2025"),
                new Student("S007","IT","21/1/2025")
            };
            Utility.BubbleSortOfArrayInAscending<Student>(unsortedStudent);
            Assert.That(unsortedStudent[0].CompareTo(student[0]) == 0);
            Assert.That(unsortedStudent[1].CompareTo(student[1]) == 0);
            Assert.That(unsortedStudent[2].CompareTo(student[2]) == 0);
            Assert.That(unsortedStudent[3].CompareTo(student[3]) == 0);
            Assert.That(unsortedStudent[4].CompareTo(student[4]) == 0);
            Assert.That(unsortedStudent[5].CompareTo(student[5]) == 0);
            Assert.That(unsortedStudent[6].CompareTo(student[6]) == 0);
            Assert.That(unsortedStudent[7].CompareTo(student[7]) == 0);
            Assert.That(unsortedStudent[8].CompareTo(student[8]) == 0);
            Assert.That(unsortedStudent[9].CompareTo(student[9]) == 0);
        }

        [Test]
        public void Test6()
        {
            // bubble sort an unsorted array of students in descending order
            Student[] unsortedStudent = new Student[]
            {
                new Student("S003","IT","17/1/2025"),
                new Student("S001","IT","15/1/2025"),
                new Student("S005","IT","19/1/2025"),
                new Student("S004","IT","18/1/2025"),
                new Student("S002","IT","16/1/2025"),
                new Student("S006","IT","20/1/2025"),
                new Student("S010","IT","24/1/2025"),
                new Student("S008","IT","22/1/2025"),
                new Student("S009","IT","23/1/2025"),
                new Student("S007","IT","21/1/2025")
            };
            Utility.BubbleSortOfArrayInDescending<Student>(unsortedStudent);
            Assert.That(unsortedStudent[0].CompareTo(student[9]) == 0);
            Assert.That(unsortedStudent[1].CompareTo(student[8]) == 0);
            Assert.That(unsortedStudent[2].CompareTo(student[7]) == 0);
            Assert.That(unsortedStudent[3].CompareTo(student[6]) == 0);
            Assert.That(unsortedStudent[4].CompareTo(student[5]) == 0);
            Assert.That(unsortedStudent[5].CompareTo(student[4]) == 0);
            Assert.That(unsortedStudent[6].CompareTo(student[3]) == 0);
            Assert.That(unsortedStudent[7].CompareTo(student[2]) == 0);
            Assert.That(unsortedStudent[8].CompareTo(student[1]) == 0);
            Assert.That(unsortedStudent[9].CompareTo(student[0]) == 0);
        }
        
    }
}