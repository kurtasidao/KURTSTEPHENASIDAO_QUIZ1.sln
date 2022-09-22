using KURTSTEPHENASIDAO_QUIZ1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITEAWD_Quiz1.Controllers
{
    public class HomeController : Controller
    {
        public static List<Student> Students = new List<Student>
        {
            new Student {Id= 1, StudentNumber="4200003", LastName="Asidao", FirstName="Kurt Stephen", Gender="Male", Birthday=new DateTime(2001,7,21),HasAgreedToTerms=true
            },
            new Student {Id= 2, StudentNumber="4200623", LastName="Asidao", FirstName="Kent Jemhiel", Gender="Male", Birthday=new DateTime(2001,7,21),HasAgreedToTerms=false
            },
            new Student {Id= 3, StudentNumber="4113245", LastName="Asidao", FirstName="Jan Mae Cazzie", Gender="Female", Birthday=new DateTime(2006,2,22),HasAgreedToTerms=true
            },
            new Student {Id= 3, StudentNumber="4113245", LastName="Asidao", FirstName="Charmie Lyn", Gender="Female", Birthday=new DateTime(1987,8,22),HasAgreedToTerms=false
            },
            new Student {Id= 3, StudentNumber="4113245", LastName="Asidao", FirstName="Jasper", Gender="Male", Birthday=new DateTime(1987,7,16),HasAgreedToTerms=true
            }
        };
        public ActionResult Index()
        {
            return View("Index", Students);
        }
    }
}