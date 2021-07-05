using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreExercise.Exercises;

namespace EFCoreExercise
{
    public class Test
    {
        static void Main(String[] args)
        {
            Exercise14 exercise14 = new();
            var test = exercise14.OrderStudentsByName("Class A");
            foreach(var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}
