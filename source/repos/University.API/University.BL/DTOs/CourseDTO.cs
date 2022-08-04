using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace University.BL.DTOs
{
    public class CourseDTO
    {
        [Required(ErrorMessage = "The field course ID is required")]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "The field title required")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field credits is required")]
        public int Credits { get; set; }
    }
}
