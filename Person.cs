using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSharp
{
    class Person
    {
        private String name;
        private String surname;
        private DateTime birth;

        public Person()
        {
            this.name = "Undefined Name";
            this.surname = "Undefined Surname";
            this.birth = new DateTime(2018, 12, 22);
        }

        public Person(String nameArg, String surnameArg, DateTime birthArg)
        {
            this.name = nameArg;
            this.surname = surnameArg;
            this.birth = birthArg;
        }

        public int Birth{
            set { this.birth = new DateTime(value, birth.Month, birth.Day); }
            get { return this.birth.Year; }         
        }

        public String getName()
        {
            return this.name;
        }

        public String getSurname()
        {
            return this.surname;
        }

        public virtual void printFullInfo()
        {
            Console.WriteLine("Name: {0}\t , Surname: {1}]\t , Birth date: {2}\t "
                , this.name, this.surname, this.Birth);
        }

        public int getPersonAge()
        {
            int age = 0;
            String[] now = DateTime.Now.ToShortDateString().Split('.');
            String[] birth = this.birth.ToShortDateString().Split('.');
            for(int i = 2; i >= 0; i--)
            {
                if(Int32.Parse(now[i]) > Int32.Parse(birth[i]))
                {
                    age += Int32.Parse(now[i]) - Int32.Parse(birth[i]);
                }
                else
                {
                    age -= 1;
                    break;
                }
            }
            Console.WriteLine(age);
            return age;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person person = (Person)obj;
                return (name == person.name) && (surname == person.surname) && (Birth == person.Birth);
            }
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return (p1.name == p2.name) && (p1.surname == p2.surname) && (p1.Birth == p2.Birth);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1.name == p2.name) && !(p1.surname == p2.surname) && !(p1.Birth == p2.Birth);
        }

    }
}
