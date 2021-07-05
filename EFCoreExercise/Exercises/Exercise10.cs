using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercise.Exercises
{
    public class Exercise10
    {
        public List<int[]> CountScoreHigherThanEight()
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);

            var students = dbContext.Students.Select(student => student);

            return students.GroupBy(s => s.Class.Name)
                           .Select(group => new[] { group.Count(), group.Count(s => s.Score > 8.0) })
                           .ToList();
        }                   
    }
}
