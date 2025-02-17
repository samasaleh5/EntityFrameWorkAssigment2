using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Stud_Course
    {

        [ForeignKey("Students")]
        public int stud_ID { get; set; }
        public Student student { get; set; }
        [ForeignKey("Courses")]
        public int Course_ID {  get; set; }
        public Course course { get; set; }

        [Required,MaxLength(2)]
        public string Grade { get; set; }
    }
}
