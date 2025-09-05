using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    class Subject
    {
        /*private string subjectCode;
        private string subjectName;
        private double cost;*/
        private static int numSubjects;

        const string DEF_SUBJECT_CODE = "Not found";
        const string DEF_SUBJECT_NAME = "Not found";
        const double DEF_COST = 0;

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double SubjectCost { get; set; }

        public static int NumSubjects
        {
            get
            {
                return numSubjects;
            }
        }

        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {

        }

        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            SubjectCost = cost;
            numSubjects++;
        }
        
        public override string ToString()
        {
            return "subjectCode: "+SubjectCode+" subjectName: "+SubjectName+" cost: " + SubjectCost;
        }
    }
}
