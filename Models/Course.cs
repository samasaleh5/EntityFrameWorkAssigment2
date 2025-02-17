using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int Duration { get; set; }

        [ForeignKey("Topic")]
        public int Top_ID { get; set; }

        [InverseProperty("Courses")]
        public Topic Topic { get; set; }
        public ICollection<Stud_Course> Stud_Course { get; set; }=new HashSet<Stud_Course>();
        public ICollection<Course_Inst> Courses { get; set; }
    }
}
