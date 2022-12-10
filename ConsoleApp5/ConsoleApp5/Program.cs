namespace ConsoleApp5
{
    enum Education {Specialist, Вachelor, SecondEducation}

  
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(/*new Person("Ivan", "Ivanov", new DateTime(2010, 10, 10)), Education.Specialist, 2*/);

            Console.WriteLine(student.ToShortString());
            student.Person = new Person("Ivan", "Ivanov", new DateTime(2010, 10, 10));
            student.Education = Education.Specialist;
            student.GroupNumber = 2;

            Exam[] exam1 = new Exam[3];
            exam1[0] = new Exam("Match", 4, new DateTime(2020, 9, 15, 10, 45, 0));
            exam1[1] = new Exam("English", 5, new DateTime(2020, 9, 15, 10, 45, 0));
            exam1[2] = new Exam("Informatic", 5, new DateTime(2020, 9, 15, 10, 45, 0));
            student.Exam = exam1;
            Console.WriteLine(student.ToFullString());




            Exam exam2 = new Exam("Geography", 5, new DateTime(2020, 9, 15, 10, 45, 0));
            student.AddExams(exam2);
            Console.WriteLine(student.ToFullString());

            Number2 n2 = new Number2();
            n2.Init();
            n2.TestSpeed();

        }
    }
}