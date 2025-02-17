using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }=new HashSet<Course>();
    }
}
