using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var gradeByStudent = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradeByStudent.ContainsKey(student))
                {
                    gradeByStudent.Add(student, new List<double>());
                }

                gradeByStudent[student].Add(grade);
            }

            var sortedStudents = gradeByStudent
                .Where(s => s.Value.Average() >= 4.5)
                .OrderByDescending(s => s.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedStudents)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }

        }
    }
}
