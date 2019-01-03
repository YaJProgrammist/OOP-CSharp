using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void SetSomeStudentProperties(Student vasya)
        {
            vasya.Name = "Василь";
            vasya.Surname = "Коваль";
            vasya.DateOfBirth = new DateTime(2000, 7, 17);
            vasya.StudentEducation = Student.Education.Bachelor;
            vasya.GroupTitle = "IП-72";
            vasya.NumOfRecordBook = 2345678;
        }

        static void AddSomeExams(Student vasya)
        {
            Examination[] newExamList = new Examination[4] {
                new Examination(3, "Основи ООП", "Муха I.П.", 100, true, new DateTime(2019, 1, 14)),
                new Examination(2, "Архiтектура комп'ютера", "Коган А.В.", 96, false, new DateTime(2018, 6, 16)),
                new Examination(2, "Психологiя конфлiкту", "Кононець М.О.", 98, true, new DateTime(2018, 6, 12)),
                new Examination(3, "Основи магiчного програмування", "Муха I.П.", 100, false, new DateTime(2019, 1, 14))
            };
            vasya.AddExams(newExamList);
        }

        static void ShowTask1(Student vasya)
        {
            Console.WriteLine("Завдання 1:");
            Student kolya = (Student)vasya.Clone();
            vasya.YearOfBirth = 2200;
            kolya.PrintFullInfo();
            Console.WriteLine();
        }

        static void ShowTask4(Student vasya)
        {
            Console.WriteLine("Завдання 4:");
            vasya.NumOfRecordBook = 1;
            vasya.NumOfRecordBook = 999999999;
        }

        static void ShowTask9(Student vasya)
        {
            Console.WriteLine("Завдання 9:");
            Console.WriteLine("Перелiчення тiльки залiкiв без iспитiв:");
            foreach (Examination i in vasya.GetDifferentiatedExams())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        static void ShowTask12(Student vasya)
        {
            Console.WriteLine("Завдання 12:");
            Examination[] sortedExams = vasya.GetSortedExams();
            Console.WriteLine("Вiдсортований за назвою масив iспитiв/залiкiв:");
            foreach (Examination i in sortedExams)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student vasya = new Student();

            SetSomeStudentProperties(vasya);

            Console.WriteLine(vasya);
            Console.WriteLine();

            AddSomeExams(vasya);

            Console.WriteLine(vasya);
            Console.WriteLine();

            vasya.PrintFullInfo();
            Console.WriteLine();
            
            ShowTask1(vasya);
            ShowTask9(vasya);
            ShowTask12(vasya);
            ShowTask4(vasya);

            Console.ReadKey();
        }
    }
}
