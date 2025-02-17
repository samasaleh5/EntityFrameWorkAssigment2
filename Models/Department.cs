using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("Instructor")]
        public int Ins_ID { get; set; }

        public Instructor Ins { get; set; }
        public DateTime HiringDate { get; set; }

        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; }= new HashSet<Student>();
        public ICollection<Instructor> Instructors { get; set; }=new HashSet<Instructor>();
    }
}
