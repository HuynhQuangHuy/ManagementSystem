using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagementSystem.Models
{
    public class Student
    { 
        public int ID { get; set; } //Theo mặc định, Entity Framework diễn giải một thuộc tính có tên IDhoặc tên lớp ID làm khóa chính.
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}