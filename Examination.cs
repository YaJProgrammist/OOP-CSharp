using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Examination
    {
        public int NumOfSem { get; private set; }
        public string SubjectTitle { get; private set; }
        public string NameOfTeacher { get; private set; }
        public int Mark { get; private set; }
        public bool IsDifferentiated { get; private set; }
        public DateTime DateOfExamination { get; private set; }

        public Examination()
        {
            NumOfSem = 1;
            SubjectTitle = "Основи програмування";
            NameOfTeacher = "Іванов I. I.";
            Mark = 100;
            IsDifferentiated = true;
            DateOfExamination = new DateTime(2019, 1, 9);
        }

        public Examination(int Num, string S, string Name, int M, bool I, DateTime D)
        {
            NumOfSem = Num;
            SubjectTitle = S;
            NameOfTeacher = Name;
            Mark = M;
            IsDifferentiated = I;
            DateOfExamination = D;
        }

        public double GetMark()
        {
            return Mark;
        }

        public override string ToString()
        {
            return "Назва предмету: " + SubjectTitle + "; Викладач: " + NameOfTeacher + "; Бал: " + Mark;
        }
    }
}
