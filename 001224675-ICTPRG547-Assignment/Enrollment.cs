using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    public class Enrollment
    {
        /*private string dateEnrolled;
        private string grade;
        private int semester;
        private Subject subject;*/
        private static int numEnrollments;

        const string DEF_DATE_ENROLLED = "Not enrolled";
        const string DEF_GRADE = "Not graded";
        const int DEF_SEMESTER = -1;
        /// <summary>
        /// Getters and setters for all parameters
        /// </summary>
        public string EnrollmentDateEnrolled { get; set; }
        public string EnrollmentGrade { get; set; }
        public int EnrollmentSemester { get; set; }
        public Subject EnrollmentSubject { get; set; }
        /// <summary>
        /// Static property to get the number of enrollments
        /// </summary>
        public static int NumEnrollments
        {
            get
            {
                return numEnrollments;
            }
        }
        /// <summary>
        /// Constructor that takes all parameters
        /// </summary>
        /// <param name="dateEnrolled"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        /// <param name="subject"></param>
        public Enrollment(string dateEnrolled, string grade, int semester, Subject subject)
        {
            EnrollmentDateEnrolled = dateEnrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
            numEnrollments++;
            EnrollmentSubject = subject;
        }
        /// <summary>
        /// Default constructor that uses default values for all parameters
        /// </summary>
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {

        }
        /// <summary>
        /// Constructor that takes dateEnrolled, grade and semester and uses a default subject
        /// </summary>
        /// <param name="dateEnrolled"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        public Enrollment(string dateEnrolled, string grade, int semester) : this(dateEnrolled,grade,semester,new Subject())
        {

        }
        /// <summary>
        /// Override of ToString method to display all parameters
        /// </summary>
        /// <returns>the string that was created</returns>
        public override string ToString()
        {
            return "dateEnrolled: " + EnrollmentDateEnrolled + " grade: " + EnrollmentGrade + " semester: " + EnrollmentSemester + " subject: " + EnrollmentSubject;
        }
    }
}
