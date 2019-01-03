using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
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
        public Education StudentEducation { get; set; }
        public string GroupTitle { get; set; }
        private int numOfRecordBook;
        public int NumOfRecordBook
        {
            get
            {
                return numOfRecordBook;
            }

            set
            {
                if (value <= 99999 || value > 99999999)
                {
                    throw new Exception("Помилка! Значення за межами припустимого дiапазону. Значення властивостi повиннi знаходитись в межах вiд 100000 до 99999999 включно.");
                }
                numOfRecordBook = value;
            }
        }
        public List<Examination> ExamList = new List<Examination>();
        public double Average
        {
            get
            {
                double res = 0, num = ExamList.Count();
                foreach (Examination i in ExamList)
                {
                    res += i.GetMark();
                }
                return res / num;
            }
        }

        public void AddExams(Examination[] newExamList)
        {
            ExamList.AddRange(newExamList);
        }

        public override string ToString()
        {
            return "Iм'я: " + Name + "; Прiзвище: " + Surname + "; Група: " + GroupTitle;
        }

        public override void PrintFullInfo()
        {
            Console.WriteLine("Iм'я: " + Name);
            Console.WriteLine("Прiзвище: " + Surname);
            Console.WriteLine("Дата народження: " + DateOfBirth.ToShortDateString());
            Console.WriteLine("Рiвень квалiфiкацii: " + StudentEducation);
            Console.WriteLine("Група: " + GroupTitle);
            Console.WriteLine("Номер залiковки: " + NumOfRecordBook);
            Console.WriteLine("Зданi iспити/залiки: ");
            if (ExamList.Count == 0)
            {
                Console.WriteLine("Зданi iспити/залiки відсутні.");
            }
            else
            {
                foreach (Examination i in ExamList)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Середнiй бал: " + Average);
        }

        public System.Collections.IEnumerable GetDifferentiatedExams()
        {
            foreach (Examination i in ExamList)
            {
                if (!i.IsDifferentiated)
                {
                    yield return i;
                }
            }
            yield break;
        }

        public Examination[] GetSortedExams()
        {
            return ExamList.OrderBy(o => o.SubjectTitle).ToArray();
        }

        public object Clone()
        {
            Student studClone = new Student();
            studClone.Name = this.Name;
            studClone.Surname = this.Surname;
            studClone.DateOfBirth = this.DateOfBirth;
            studClone.StudentEducation = this.StudentEducation;
            studClone.GroupTitle = this.GroupTitle;
            studClone.NumOfRecordBook = this.NumOfRecordBook;
            foreach (Examination i in this.ExamList)
            {
                studClone.ExamList.Add(i);
            }
            return studClone;
        }
    }
}
