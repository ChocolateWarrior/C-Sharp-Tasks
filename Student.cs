using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSharp
{
    class Student : Person, ICloneable
    {
        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation,
            PhD
        }

        private Education curEducation;
        private String groupName;
        private int gradebookNum;
        private List<Examination> allExams = new List<Examination>();
        private List<Examination> passedExams = new List<Examination>();

        public Student() : base(){}

        public object Clone() {
            return new Student {
                EducationProp = this.EducationProp,
                GroupNumProp = this.GroupNumProp,
                GradebookNumProp = this.GradebookNumProp,
                PassedExamsProp = this.PassedExamsProp
            };
        }


        public Student(String name, String surname, DateTime birth): base(name, surname, birth)
        {
            this.curEducation = 0;
            this.groupName = "undefined";
            this.gradebookNum = 0;
   
        } 

        public Education EducationProp
        {
            set { curEducation = value; }
            get { return curEducation; }
        }

        public String GroupNumProp
        {
            set { groupName = value; }
            get { return groupName; }
        }

        public int GradebookNumProp
        {
            set { gradebookNum = value; }
            get { return gradebookNum; }
        }

        public Examination PassedExamsProp
        {
            set
            {
                    passedExams.Add(value);
            }
            get
            {
                for (int j = 0; j < passedExams.Count; j++)
                {
                    return passedExams[j];
                }
                return null;
            }
        }

        public double AverageProp
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < passedExams.Count; i++)
                {
                    sum += passedExams[i].getMark();
                }
                return sum / passedExams.Count;
            }
        }

        public void addExams(Examination[] examList)
        {
            for(int i = 0; i < examList.Length; i++)
            {
                allExams.Add(examList[i]);
            }
        }

        public override String ToString()
        {
            return "Name: " + this.getName() + " Surname: " 
                + this.getSurname() + " Group: " + this.groupName;

        }

        public override void printFullInfo()
        {
            Console.WriteLine("Name: " + this.getName() + " Surname: "
                + this.getSurname() + " Birth: " + this.Birth.ToString()
                + " Group: " + this.groupName + " Gradebook: " + this.gradebookNum
                + " Education level: " + this.EducationProp + " Average mark: " + this.AverageProp );
            Console.WriteLine("All exams:");
            for(int i = 0; i < allExams.Count; i++)
            {
                Console.WriteLine(allExams[i].ToString());
            }
        }

        public string getExaminations(int mark)
        {
            string fullInfo = "";
            foreach (var exam in allExams)
            {
                if (exam.ExaminationMark >= mark)
                    fullInfo += exam.ToString() + "\n";
            }

            return fullInfo;
        }

    }
}
