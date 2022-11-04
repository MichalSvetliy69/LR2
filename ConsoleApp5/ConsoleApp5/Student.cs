using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Student
    {
        Person person;
        Education education;
        int groupNumber;
        Exam[] exam;
        double midrating;
        public Student(Person person, Education education, int groupNumber)
        {
            this.person = person;
            this.education = education;
            this.groupNumber = groupNumber;
        }

        public Student()
        {
            this.person = new Person();
            this.education = new Education();
            this.groupNumber = -1;
        }

        public Person Person
        {
            get { return this.person; }
            set { this.person = value; }
        }
        public Education Education
        {
            get { return this.education; }
            set { this.education = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public Exam[] Exam
        {
            get { return this.exam; }
            set { this.exam = value; }
        }

        public double MidRating
        {
            get
            {
                if (exam != null)
                {
                    double sum = 0;
                    double n = 0;
                    foreach (var i in exam)
                    {
                        sum += i.Rating;
                        n += 1;
                    }
                    return Math.Round(sum / n, 1);
                }
                else
                {
                    return 0;
                }
               
            }
        }

        public void AddExams(Exam exam)
        {
            Array.Resize(ref this.exam, this.exam.Length + 1);
            this.exam[this.exam.Length - 1] = exam;

        }

        public string ToFullString()
        {
            string str1 = person.Name + " " + person.LastName + " " + person.Birthday + " " + education + " " + groupNumber + " ";

            str1 += "Subjects: ";
            foreach (var str in exam)
            {

                str1 += str.Subject;
                str1 += ", ";
            }
            str1 = str1[..^2];               //Удаляем последнюю лишнюю запятую
            str1 += ".";

            return str1;
        }

        public string ToShortString()
        {
            string str1 = person.Name + " " + person.LastName + " " + person.Birthday + " " + education + " " + groupNumber + " " + MidRating + " ";
            return str1;

        }
    }
}
