using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoAspNetCore.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //Get to-do items from database
            //put items into a model
            //Render view using the model
        }
    }
}