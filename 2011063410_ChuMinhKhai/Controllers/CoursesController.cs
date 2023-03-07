using _2011063410_ChuMinhKhai.Models;
using _2011063410_ChuMinhKhai.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2011063410_ChuMinhKhai.Controllers
{
    public class CoursesController : Controller
    {
        // GET: CoursesController
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CouseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
    }