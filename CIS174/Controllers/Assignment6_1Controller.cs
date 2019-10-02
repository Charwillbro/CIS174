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
        [Route("{controller=Assignment6_1}/{action=Index}/{accessLevel:range(1,10)}")]
        public IActionResult Index(int accessLevel)
        {
            var id = accessLevel;
            var student1 = new StudentModel();
            var student2 = new StudentModel();
            var student3 = new StudentModel();
            var student4 = new StudentModel();
            var Students = new List<StudentModel> { student1, student2, student3, student4 };
            
            if(id >= 2)
            {
                student1.FirstName = "Charles";
                student1.LastName = "Broderick";
                student2.FirstName = "Arthur";
                student2.LastName = "Dent";
                student3.FirstName = "Ford";
                student3.LastName = "Prefect";
                student4.FirstName = "Trisha";
                student4.LastName = "McMellan";
            }
            if (id >= 8)
            {
                student1.Grade = "A";
                student2.Grade = "C";
                student3.Grade = "B";
                student4.Grade = "B+";
            }

            if (id < 2) {
                student1.FirstName = "You do not have a sufficient access level to view this data.";
                student2.FirstName = "You do not have a sufficient access level to view this data.";
                student3.FirstName = "You do not have a sufficient access level to view this data.";
                student4.FirstName = "You do not have a sufficient access level to view this data.";

            }
             
            return View(Students);
            
        }
    }
}