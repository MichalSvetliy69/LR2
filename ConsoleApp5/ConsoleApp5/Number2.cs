using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Number2
    {
        Exam[] exam;
        Exam[,] exam1;
        Exam[][] exam2;
        Random rand = new Random();
        int nrow, ncol,count = 1;
        string[] subjectsMass = { "Match", "Geography", "EnglishLanguage", "RussianLanguage", "Physicist", "Informatic", "Biology", "Stinks", "History", "Literature", "Sport" };
        public void Init()
        {

            var strRead = Console.ReadLine().Split(new char[] { ' ', ',','.' });
            int nrow = int.Parse(strRead[0]);
            this.nrow = nrow;
            int ncol = int.Parse(strRead[1]);
            this.ncol = ncol;


            var exam = new Exam[nrow * ncol];
            this.exam = exam;



            var exam1 = new Exam[nrow, ncol];
            this.exam1 = exam1;


            var exam2 = new Exam[nrow][];
            this.exam2 = exam2;
            for (var i = 0; i < nrow; i++)
            {
                exam2[i] = new Exam[ncol];
            }






        }

        public void TestSpeed()
        {
            int timer1_before = Environment.TickCount & Int32.MaxValue;
            for (int i = 0; i < nrow*ncol; i++)
            {
                string subject = subjectsMass[rand.Next(0, subjectsMass.Length)];
                int score = rand.Next(2, 6);
                DateTime dt = new DateTime(2020, 9, 15, rand.Next(8, 14), rand.Next(0, 59), 0);
                exam[i] = new Exam(subject, score, dt);
                Console.WriteLine($"Exam {count} : {exam[i].Subject} an {exam[i].ExamDate} Score : {exam[i].Rating}");
                count++;
            }
            int timer1_after = Environment.TickCount & Int32.MaxValue;
            int timer1 = timer1_after - timer1_before;

            count = 0;

            int timer2_before = Environment.TickCount & Int32.MaxValue;
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    string subject = subjectsMass[rand.Next(0, subjectsMass.Length)];
                    int score = rand.Next(2, 6);
                    DateTime dt = new DateTime(2020, 9, 15, rand.Next(8, 14), rand.Next(0, 59), 0);
                    exam1[i, j] = new Exam(subject, score, dt);
                    Console.WriteLine($"Exam1 {count} : {exam1[i, j].Subject} an {exam1[i, j].ExamDate} Score : {exam1[i, j].Rating}");
                    count++;
                }
            }
            int timer2_after = Environment.TickCount & Int32.MaxValue;
            int timer2 = timer2_after - timer2_before;

            count = 0;

            int timer3_before = Environment.TickCount & Int32.MaxValue;
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    string subject = subjectsMass[rand.Next(0, subjectsMass.Length)];
                    int score = rand.Next(2, 6);
                    DateTime dt = new DateTime(2020, 9, 15, rand.Next(8, 14), rand.Next(0, 59), 0);
                    exam2[i][j] = new Exam(subject, score, dt);
                    Console.WriteLine($"Exam2 {count} : {exam2[i][j].Subject} an {exam2[i][j].ExamDate} Score : {exam2[i][j].Rating}");
                    count++;
                }
            }
            int timer3_after = Environment.TickCount & Int32.MaxValue;
            int timer3 = timer3_after - timer3_before;


            Console.WriteLine($"one-dimensional: {timer1} ms");
            Console.WriteLine($"two-dimensional: {timer2} ms");
            Console.WriteLine($"jagged array: {timer3} ms");
        }


    }
}
