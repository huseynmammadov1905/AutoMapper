using AutoMapper;
using AutomapperTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperTask.Controllers
{
    public class PersonController : Controller
    {
        private readonly static List<Person> people = new();
        private readonly IMapper _mapper;

        public PersonController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(people);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult AddPerson(PersonDTO personDTO)
        {
            if (ModelState.IsValid)
            {
                Person person = _mapper.Map<Person>(personDTO);

                people.Add(person);
                return RedirectToAction("Index");
            }
            return View(personDTO);
        
        }
    }
}
