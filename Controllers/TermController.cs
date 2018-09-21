using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TermAPI.Controllers {
    public class TermController : Controller {
        public IActionResult Index() {
            return Content("This is the term page");
        }

        public IActionResult Current() {
            return Content("wip");
        }

    }
}