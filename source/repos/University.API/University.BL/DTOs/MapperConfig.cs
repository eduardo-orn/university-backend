using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using University.BL.DTOs;
using University.BL.Models;

namespace University.BL.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Course, CourseDTO>(); //GET
                cfg.CreateMap<CourseDTO, Course>();  //POST, PUT

                cfg.CreateMap<Student, StudentDTO>(); 
                cfg.CreateMap<StudentDTO, Student>();

                cfg.CreateMap<Enrollment, EnrollmentDTO>();
                cfg.CreateMap<EnrollmentDTO, Enrollment>();
            });
        }
    }
}
