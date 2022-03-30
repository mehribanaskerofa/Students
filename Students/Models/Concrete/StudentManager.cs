using Students.Models.Abstract;
using Students.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models.Concrete
{
    public class StudentManager : IStudent
    {

        Context context;
        public void AddStudent(Student student)
        {
            context = new Context();
            context.Students.Add(student);
            context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            context = new Context();
            return context.Students.ToList();
        }

    }  
}