using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercise.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
