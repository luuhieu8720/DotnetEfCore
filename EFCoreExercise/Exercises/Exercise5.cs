using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercise.Exercises
{
    public class Exercise5
    {
        public List<string> MaxScoreGroupByClass()
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);

            var students = dbContext.Students
                .Include(x => x.Class)
                .Where(x => x.Class != null)
                .Select(student => student)
                .ToList();

            return students.GroupBy(student => student.Class.Name)
                           .Select(group => group.OrderBy(s => s.Score)
                                                    .Last()
                                                    .Name)
                            .ToList();
        }
    }
}
