using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCApp1.DataAccess;

namespace MVCApp1.Controllers
{
    
    public class PersonController : Controller
    {

        private readonly MyDbContext _dbContext;

        public PersonController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {                       
            return View();
        }


        [HttpPost]
        public IActionResult Add(Person person)
        {


            _dbContext.Add(person);
            _dbContext.SaveChanges();

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public IActionResult GetAll()
        {

            List<Person> people = _dbContext.People.ToList();
            return View(people);
        }


    }
}
