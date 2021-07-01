using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercise.Exercises
{
    public class Exercise7
    {
        public List<double?> FindAllScores()
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);
            return dbContext.Student.Select(s => s.Score).Distinct().ToList();
        }
    }
}
