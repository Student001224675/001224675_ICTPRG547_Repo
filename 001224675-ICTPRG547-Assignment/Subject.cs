using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    public class Subject
    {
        /*private string subjectCode;
        private string subjectName;
        private double cost;*/
        private static int numSubjects;

        const string DEF_SUBJECT_CODE = "No code";
        const string DEF_SUBJECT_NAME = "No name";
        const double DEF_COST = -0.1;
        /// <summary>
        /// Getters and setters for all parameters
        /// </summary>
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double SubjectCost { get; set; }
        /// <summary>
        /// Static property to get the number of subjects
        /// </summary>
        public static int NumSubjects
        {
            get
            {
                return numSubjects;
            }
        }
        /// <summary>
        /// Default constructor that uses default values for all parameters
        /// </summary>
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {

        }
        /// <summary>
        /// Constructor that takes all parameters
        /// </summary>
        /// <param name="subjectCode"></param>
        /// <param name="subjectName"></param>
        /// <param name="cost"></param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            SubjectCost = cost;
            numSubjects++;
        }
        /// <summary>
        /// Override toString method to display all parameters
        /// </summary>
        /// <returns>the string that was created</returns>
        public override string ToString()
        {
            return "subjectCode: "+SubjectCode+" subjectName: "+SubjectName+" cost: " + SubjectCost;
        }
    }
}
