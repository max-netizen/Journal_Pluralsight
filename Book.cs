using System;
using System.Collections.Generic;
using System.Text;

namespace Journal_Pluralsight
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public List<double> getGrades()
        {
            return grades;
        }

        public Statistics getStatistcs()
        {
            Statistics statistics = new Statistics(grades);
            return statistics;
        }

        public void ShowStatistcs()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N3}");
            Console.WriteLine($"The lowest grade is {lowGrade:N3}");
            Console.WriteLine($"The highest grade is {highGrade:N3}");
        }
        public List<double> grades;
        public string Name;
    }
}
