﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
