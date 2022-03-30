using Students.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Models.Abstract
{
    public interface IStudent
    {
          List<Student> GetAll();
          void AddStudent(Student student);      
    }
}
