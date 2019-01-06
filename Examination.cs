using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSharp
{
    class Examination
    {
        private int semesterNum;
        private String subjectName;
        private String examinatorName;
        private int examinationMark;
        public bool examinationType;
        private DateTime examinationDate;

        public int SemesterNum
        {
            get { return this.semesterNum; }
            set
            {   
                if (value >= 0 && value <= 12)
                {
                    this.semesterNum = value;
                }
            }
            
        }

        public int ExaminationMark
        {
            get { return this.examinationMark; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.examinationMark = value;
                }
            }
        }

        public String SubjectName { get; set; }
        public String ExaminatorName { get; set; }
        private bool ExaminationType { get; set; }
        private DateTime ExaminationDate { get; set; }


        public Examination()
        {
            this.semesterNum = 0;
            this.subjectName = "Undefined Subject";
            this.examinatorName = "Undefined Exaaminator";
            this.examinationMark = 0;
            this.examinationType = false;
            this.examinationDate = new DateTime(2018, 12, 22);
        }

        public Examination(int curSemNum, String curSubName, String curExtorName,
            int curExtionMark, bool curExtionType, DateTime curExtionDate)
        {
            this.semesterNum = curSemNum;
            this.subjectName = curSubName;
            this.examinatorName = curExtorName;
            this.examinationMark = curExtionMark;
            this.examinationType = curExtionType;
            this.examinationDate = curExtionDate;
        }

        public override String ToString()
        {
            return "Subject: " + this.subjectName + "\nExaminator: " 
                + this.examinatorName + "\nMark: " + this.examinationMark;

        }

        public int getMark()
        {
            return this.examinationMark;
        }
    }
}
