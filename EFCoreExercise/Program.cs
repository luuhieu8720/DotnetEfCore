using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using EFCoreExercise.Models;
using EFCoreExercise.Exercises;
using System.Collections.Generic;

namespace EFCoreExercise
{
    class Program
    {
        static void InsertClass(string name)
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);

            dbContext.Class.Add(new Class()
            {
                Name = name
            });

            dbContext.SaveChanges();
        }
        static void InsertStudent(string name, Class @class, DateTime birthday, double score)
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);

            dbContext.Student.Add(new Student()
            {
                Name = name,
                Class = @class,
                Birthday = birthday,
                Score = score
            });

            dbContext.SaveChanges();
        }
        static void Main(string[] args)
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);
            var className = dbContext.Student.Select(s => s.Class.Name).ToList();
            var students = dbContext.Student.Select(s => s).ToList();
            Console.WriteLine("Student list:");
            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].Name}, {className[i]}, {students[i].Birthday.ToString("MM/dd/yyyy")}, {students[i].Score}");
            }

            var listName = new List<string>() { };
            var listScore = new List<double?>() { };

            Exercise1 exercise1 = new();
            Console.WriteLine("\nGet score by student ID: ");
            Console.WriteLine(exercise1.GetScoreById(1088));
            
            /*Exercise2 exercise2 = new();
            var listStudent = exercise2.GetStudentsByYear(2000);
            Console.WriteLine("\nGet list of students by birthday year: ");
            foreach (var item in listStudent)
            {
                Console.Write($"{item}, ");
            }
            
            Exercise3 exercise3 = new();
            listStudent = exercise3.GetStudentsByClass("Class A");
            Console.WriteLine("\n\nGet list of students by class name: ");
            foreach (var item in listStudent)
            {
                Console.Write($"{item}, ");
            }

            Exercise4 exercise4 = new();
            var averageScore = exercise4.AverageScore("Class A");
            Console.WriteLine("\n\nAverage score: {0}",averageScore);
            
            Exercise5 exercise5 = new();
            Console.WriteLine("\nMax score group by class: ");
            listName = exercise5.MaxScoreGroupByClass();
            foreach (var item in listName)
            {
                Console.WriteLine(item);
            }

            Exercise6 exercise6 = new();
            Console.WriteLine("\nList of students having name contains 'a': ");
            listName = exercise6.FindStudentContainsName("a");
            foreach (var item in listName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAppeared points: ");
            Exercise7 exercise7 = new();
            listScore = exercise7.FindAllScores();
            foreach(var item in listScore) {
                Console.WriteLine(item);
            }

            Exercise8 exercise8 = new();
            listName = exercise8.ScoreLowerThanFiveStudents();
            Console.WriteLine("\nList of students having score lower than 5:");
            foreach (var item in listName)
            {
                Console.WriteLine(item);
            }

            Exercise9 exercise9 = new();
            listName = exercise9.StudentsWithoutScore();
            Console.WriteLine("\nList of students having no score: ");
            foreach(var item in listName)
            {
                Console.WriteLine(item);
            }

            Exercise10 exercise10 = new();
            var count = new List<int[]>();
            count = exercise10.CountScoreHigherThanEight();
            Console.WriteLine("\nCount number of students and number of students having score higher than 8: ");
            foreach(var item in count)
            {
                Console.WriteLine($"{item[0]}, {item[1]}");
            }

            Exercise11 exercise11 = new();
            var @class = exercise11.ClassHasHighestScore();
            Console.WriteLine($"\nClass has highest average score: {@class}");
            

            Exercise12 exercise12 = new();
            listName = exercise12.RandomFiveStudentByClass("Class A");
            Console.WriteLine($"\n5 random students selected by class name:");
            foreach (var item in listName)
            {
                Console.WriteLine(item);
            }

            Exercise13 exercise13 = new();
            Console.WriteLine($"\nIf class A has any student born in 2000 + score > 8.0 or not: " +
                $"{exercise13.CheckStudent(2000,8.0)}");

            Exercise14 exercise14 = new();
            Console.WriteLine("\nOrder students by name: ");
            listName = exercise14.OrderStudentsByName("Class A");
            foreach(var item in listName)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
