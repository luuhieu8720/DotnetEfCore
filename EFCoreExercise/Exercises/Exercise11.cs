using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercise.Exercises
{
    public class Exercise11
    {
        public string ClassHasHighestScore()
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);

            var students = dbContext.Students.Select(student => student);
            
            return students.GroupBy(student => student.Class.Name)
                           .Select(group => new { className = group.Key, score = group.Average(s => s.Score) })
                           .OrderByDescending(dict => dict.score)
                           .First().className;
        }
    }
}
