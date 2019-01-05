namespace SoftUniBabies.Controllers
{
    using Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class BabyController : Controller
    {
        private readonly BabyDbContext dbContext;

        public BabyController(BabyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //TODO
            return null;
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            //TODO
            return null;
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Baby baby)
        {
            //TODO
            return null;
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            //TODO
            return null;
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Baby baby)
        {
            //TODO
            return null;
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            //TODO
            return null;
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Baby baby)
        {
            //TODO
            return null;
        }
    }
}
