using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174.Models;
using Microsoft.AspNetCore.Mvc;



namespace CIS174.Controllers
{
    public class Assignment6_1Controller : Controller
    {

        public IActionResult Index()
        {
            var student1 = new StudentModel();
            var student2 = new StudentModel();
            var student3 = new StudentModel();
            var student4 = new StudentModel();
            var Students = new List<StudentModel> { student1, student2, student3, student4 };
            student1.FirstName = "Charles";
            student1.LastName = "Broderick";
            student1.Grade = "A";
            student2.FirstName = "Arthur";
            student2.LastName = "Dent";
            student2.Grade = "C";
            student3.FirstName = "Ford";
            student3.LastName = "Prefect";
            student3.Grade = "B";
            student4.FirstName = "Trisha";
            student4.LastName = "McMellan";
            student4.Grade = "B+";


            return View(Students);
            //return View();
        }

    }
}