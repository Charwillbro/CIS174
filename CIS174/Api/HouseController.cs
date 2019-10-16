using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174.Api
{
    [Route("api/house")]
    [ApiController]

    public class HouseController : Controller
    {


        System.Collections.Generic.IEnumerable<HouseViewModel> Houses = new List<HouseViewModel>() {
            new HouseViewModel { Id = 1, Bedrooms = 4, SquareFeet = 1854, DateBuilt = Convert.ToDateTime("05/28/1973"), Flooring = "Carpet" },
            new HouseViewModel { Id = 2, Bedrooms = 3, SquareFeet = 1675, DateBuilt = Convert.ToDateTime("10/17/2015"), Flooring = "Hardwood" }
        };
        
        [HttpGet]
        public IActionResult Get()
        { 
            return Ok(Houses);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IEnumerable<HouseViewModel> foundHouse = Houses.Where(Houses => Houses.Id == id);
           
            if (foundHouse.Count()>0)
            {
                return Ok(foundHouse);
            }
            return NotFound();    
        }

        [HttpPost("/create")]
        public IActionResult Post([FromBody] HouseViewModel houseIn )
        {
            return Ok(houseIn);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}