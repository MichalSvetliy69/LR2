using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Exam
    {
        string subject;
        int rating;
        DateTime examDate;

        public Exam(string subject, int rating, DateTime examDate)
        {
            this.subject = subject;
            this.rating = rating;
            this.examDate = examDate;
        }
        public Exam()
        {
            this.subject = "subject";
            this.rating = -1;
            this.examDate = new DateTime(0, 0, 0, 10, 30, 0);
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public DateTime ExamDate
        {
            get { return examDate; }
            set { examDate = value; }
        }
        string ToFullString()
        {
            return subject + " " + rating + " " + examDate.ToString();
        }
    }
}
