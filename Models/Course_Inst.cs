using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Course_Inst
    {

        [ForeignKey("Instructors")]
        public int inst_ID {  get; set; }

        public Instructor inst { get; set; }

        [ForeignKey("Courses")]
        public int Course_ID { get; set; }
        public Course courses { get; set; }
        [MaxLength(500)]
        public string Evaluate {  get; set; }
    }
}
