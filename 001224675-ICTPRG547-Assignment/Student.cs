using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    public class Student:Person,IComparable<Student>
    {
        /*private string studentID;
        private string program;
        private string dateRegistered;
        private Enrollment enrollment;*/
        private static int numStudents;

        const string DEF_STUDENT_ID = "Not Found";
        const string DEF_PROGRAM = "Not found";
        const string DEF_DATE_REGISTERED = "Not found";
        const string DEF_NAME = "Not Found";
        const string DEF_EMAIL = "Not found";
        const string DEF_PHONE_NUMBER = "Not found";

        /// <summary>
        /// Getters and setters for all parameters
        /// </summary>
        public string StudentID { get; set; }
        public string StudentProgram { get; set; }
        public string StudentDateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }
        /// <summary>
        /// Static property to get the number of students
        /// </summary>
        public static int NumStudents
        {
            get
            {
                return numStudents;
            }
        }
        /// <summary>
        /// Default constructor that uses default values for all parameters
        /// </summary>
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED,new Enrollment(),DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER, new Address())
        {

        }
        /// <summary>
        /// Constructor that takes all parameters
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        /// <param name="enrollment"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        public Student (string studentID, string program, string dateRegistered, Enrollment enrollment,string name,string email,string phoneNumber,Address address) : base(name,email,phoneNumber,address)
        {
            StudentID = studentID;
            StudentProgram = program;
            StudentDateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
            numStudents++;
        }
        /// <summary>
        /// Constructor that uses default values for person and enrollment
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        public Student(string studentID, string program, string dateRegistered) : this(studentID,program,dateRegistered,new Enrollment(),DEF_NAME,DEF_EMAIL,DEF_PHONE_NUMBER,new Address())
        {

        }
        /// <summary>
        /// Override ToString to include student details
        /// </summary>
        /// <returns>the string that is created</returns>
        public override string ToString()
        {
            return base.ToString() + "studentID: "+ StudentID + " program: "+ StudentProgram+" dateRegistered: "+StudentDateRegistered+" enrollment: "+ StudentEnrollment;
        }
        /// <summary>
        /// Override Equals so that two students are equal if their StudentID is the same
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the two students are equal</returns>
        public override bool Equals(object? obj)
        {
            if ( obj == null)
                return false;
            if(ReferenceEquals(this,obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student s1 = (Student)obj;
            return s1.StudentID == this.StudentID;
        }
        /// <summary>
        /// Equal operator
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>whether s1 and s2 are equal</returns>
        public static bool operator ==(Student s1, Student s2)
        {
            return object.Equals(s1, s2);
        }
        /// <summary>
        /// Not equal operator
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>whether s1 and s2 are not equal</returns>
        public static bool operator !=(Student s1, Student s2)
        {
            return !object.Equals(s1, s2);
        }
        /// <summary>
        /// Override GetHashCode so that it is consistent with Equals
        /// </summary>
        /// <returns>StudentID.GetHashCode</returns>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        public int CompareTo(Student other)
        {
            return StudentID.CompareTo(other.StudentID);
        }
    }
}
