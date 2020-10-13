using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RottenTomatoesMoviesProject.BusinessLogic.Abstract;
using RottenTomatoesMoviesProject.Entity.Model;
using RottenTomatoesMoviesProject.Presentation.Models;

namespace RottenTomatoesMoviesProject.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IProjectService project;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IProjectService _project, ILogger<HomeController> logger)
        {
            project = _project;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string q="", int page_limit=10, int page=1)
        {
            MoviesResponse list = new MoviesResponse();
            list = await project.GetList(q, page_limit, page);
            list.pagecount = (int)Math.Ceiling((double)(list.total / (double)page_limit));
            list.pagelimit = page_limit;
            list.page = page;

            return View(list);
        }

        public async Task<IActionResult> Detail(int id)
        {
            MovieDetail list = new MovieDetail();
            list = await project.Get(id);

            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
