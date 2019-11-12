using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIS174.Entities;
using CIS174.Filters;

namespace CIS174.Controllers
{
    public class Assignment10_1Controller : Controller
    {
        private readonly PersonAccomplishmentContext _context;

        public Assignment10_1Controller(PersonAccomplishmentContext context)
        {
            _context = context;
        }

        // GET: Assignment10_1
        public async Task<IActionResult> Index()
        {
            return View(await _context.People.ToListAsync());
        }

        // GET: Assignment10_1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People.SingleOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: Assignment10_1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Assignment10_1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateModelAttribute]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Birthdate,City,State")] Person person)
        {
           // if (ModelState.IsValid)
           //{
                _context.Add(person);
               await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           // }
           // return View(person);
        }


        //readonly AppDbContext _context;
        //public int CreatePerson( Person cmd)
        //{
        //    var person = new Person
        //    {
        //        FirstName = cmd.FirstName,
        //        LastName = cmd.LastName,
        //        Birthdate = new DateTime(cmd.Birthdate),
        //        City= cmd.City,
        //        State = cmd.State,
               
        //        Accomplishments = cmd.Accomplishments?.Select(i => new Accomplishment
        //        {
        //            Name = i.Name,
        //            DateOfAccomplishment = new DateTime(cmd.DateOfAccomplishment),
                    
        //        }).ToList()
        //    };
        //    _context.Add(Person);
        //    _context.SaveChanges();
        //    return Person.Id;
        //}


        // GET: Assignment10_1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        // POST: Assignment10_1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Birthdate,City,State")] Person person)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: Assignment10_1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People
                .SingleOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: Assignment10_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.People.FindAsync(id);
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.People.Any(e => e.Id == id);
        }
    }
}
