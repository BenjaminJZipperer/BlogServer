﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Side_App.Models
{
    [Table("Book")] // Bind later 
    public class Bool 
    {
        [Key]
        public Guid   Id    { get; set; }
        public string Name  { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
    }
}
