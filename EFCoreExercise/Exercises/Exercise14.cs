using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercise.Exercises
{
    public class Exercise14
    {
        public List<string> OrderStudentsByName(string className)
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);

            var students = dbContext.Students.Where(x => x.Class.Name == className).ToList();

            return students.AsEnumerable()
                           .OrderBy(s => s.Name.Split(" ").Last())
                           .ThenBy(s => s.Name)
                           .Select(s => s.Name)
                           .ToList();
        }
    }
}
