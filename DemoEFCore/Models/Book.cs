using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoEFCore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PublishYear { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public virtual Author Author { get; set; }
    }
}
