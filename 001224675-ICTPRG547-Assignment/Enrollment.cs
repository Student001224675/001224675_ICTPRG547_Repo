using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    class Enrollment
    {
        /*private string dateEnrolled;
        private string grade;
        private int semester;
        private Subject subject;*/
        private static int numEnrollments;

        const string DEF_DATE_ENROLLED = "Not found";
        const string DEF_GRADE = "Not found";
        const int DEF_SEMESTER = 0;

        public string EnrollmentDateEnrolled { get; set; }
        public string EnrollmentGrade { get; set; }
        public int EnrollmentSemester { get; set; }
        public Subject EnrollmentSubject { get; set; }

        public static int NumEnrollments
        {
            get
            {
                return numEnrollments;
            }
        }

        public Enrollment(string dateEnrolled, string grade, int semester, Subject subject)
        {
            EnrollmentDateEnrolled = dateEnrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
            numEnrollments++;
            EnrollmentSubject = subject;
        }

        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {

        }

        public Enrollment(string dateEnrolled, string grade, int semester) : this(dateEnrolled,grade,semester,new Subject())
        {

        }

        public override string ToString()
        {
            return "dateEnrolled: " + EnrollmentDateEnrolled + " grade: " + EnrollmentGrade + " semester: " + EnrollmentSemester + " subject: " + EnrollmentSubject;
        }
    }
}
