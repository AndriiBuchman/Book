using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskBackEnd.DTOs
{
    public class BookDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
