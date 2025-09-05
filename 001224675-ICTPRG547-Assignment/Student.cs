using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    class Student:Person
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

        public string StudentID { get; set; }
        public string StudentProgram { get; set; }
        public string StudentDateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }
        public static int NumStudents
        {
            get
            {
                return numStudents;
            }
        }

        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED,new Enrollment(),DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER, new Address())
        {

        }

        public Student (string studentID, string program, string dateRegistered, Enrollment enrollment,string name,string email,string phoneNumber,Address address) : base(name,email,phoneNumber,address)
        {
            StudentID = studentID;
            StudentProgram = program;
            StudentDateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
            numStudents++;
        }
        public Student(string studentID, string program, string dateRegistered) : this(studentID,program,dateRegistered,new Enrollment(),DEF_NAME,DEF_EMAIL,DEF_PHONE_NUMBER,new Address())
        {

        }

        public override string ToString()
        {
            return base.ToString() + "studentID: "+ StudentID + " program: "+ StudentProgram+" dateRegistered: "+StudentDateRegistered+" enrollment: "+ StudentEnrollment;
        }
    }
}
