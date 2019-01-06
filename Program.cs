using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 05, 31);
            DateTime exam1Date = new DateTime(2018, 12, 18);
            DateTime exam2Date = new DateTime(2018, 12, 22);
            DateTime exam3Date = new DateTime(2019, 01, 7);
            DateTime exam4Date = new DateTime(2018, 12, 24);



            Student mark = new Student("Mark", "Zubach", date);
            Examination PCD = new Examination(3, "PCD", "Covtunetz", 95, true, exam1Date);
            Examination PHILOSOPHY = new Examination(3, "PHILOSOPHY", "Cutsick", 90, true, exam2Date);
            Examination OOP = new Examination(3, "OOP", "Mukha", 85, true, exam3Date);
            Examination TY = new Examination(3, "TY", "Harko", 100, true, exam4Date);
            Examination[] examArr = new Examination[4] {PCD, PHILOSOPHY, OOP, TY};

            mark.EducationProp = 0;
            mark.GradebookNumProp = 7109;
            mark.GroupNumProp = "IP-71";
            mark.PassedExamsProp = PCD;
            mark.addExams(examArr);

            Console.WriteLine("Overwriten ToString method:");
            Console.WriteLine(mark.ToString());
            Console.WriteLine();

            Console.WriteLine("All marks info:");
            mark.printFullInfo();
            Console.WriteLine();

            Console.WriteLine("Marks age: ");
            mark.getPersonAge();
            Console.WriteLine();

            Console.WriteLine("Examinations with mark higher or equal to 90: ");
            Console.WriteLine(mark.getExaminations(90));
            Console.WriteLine();

        }
    }
}
