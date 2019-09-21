using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DIContainerConfig.Models;

namespace DIContainerConfig.Controllers
{
    public class HomeController : Controller
    {
        public IPersonRepository PersonRepository  { get; set; }
        private readonly ISingletonRepository singletonRepository;
        private readonly IScopeRepository scopeRepository;
        private readonly ITransiantRepository transiantRepository;
        private Dictionary<string, Person> people;
        public HomeController(IPersonRepository personRepository, ISingletonRepository singletonRepository, IScopeRepository scopeRepository, ITransiantRepository transiantRepository)
        {
            PersonRepository = personRepository;
            this.singletonRepository = singletonRepository;
            this.scopeRepository = scopeRepository;
            this.transiantRepository = transiantRepository;
        }
        public IActionResult Index()
        {
            ViewData["Singleton"] = singletonRepository.Id;
            
            return View(PersonRepository.People);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
