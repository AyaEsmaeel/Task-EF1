using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1_EF
{
    internal class TaskK
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; } //=null!;
        public string? Description { get; set; }
        public DateTime Date { get; set; }
    }
}
