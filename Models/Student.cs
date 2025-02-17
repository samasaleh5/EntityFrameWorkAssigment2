using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string FName { get; set; }
        [Required,MaxLength(50)]
        public string LName { get; set; }
        [Required,MaxLength(255)]
        public string Address { get; set; }
        [Range(18,25)]
        public int age { get; set; }
        [ForeignKey("Department")]
        public int? Dep_id { get; set; }


        [InverseProperty("Students")]
        public Department Department { get; set; }

        public ICollection<Stud_Course> Courses { get; set; }

    }
}
