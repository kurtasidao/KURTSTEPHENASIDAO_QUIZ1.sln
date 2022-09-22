using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KURTSTEPHENASIDAO_QUIZ1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public bool HasAgreedToTerms { get; set; }
    }
}