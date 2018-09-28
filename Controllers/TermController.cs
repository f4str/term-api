using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TermAPI.Models;

namespace TermAPI.Controllers {
    public class TermController : Controller {

        public IActionResult Index() {
            return RedirectToAction("index", "home");
        }

        public IActionResult Current() {
            DateTime date = DateTime.Today;
            Term term = new Term(date);
            return new ObjectResult(term);
        }

        [Route("term/{date:datetime}")]
        public IActionResult SpecificDate(DateTime date) {
            Term term = new Term(date);
            return new ObjectResult(term);
        }

        [Route("term/{code:max(9999)}")]
        public IActionResult TermCode(int code) {
            Term term = new Term(code);
            return new ObjectResult(term);
        }

    }
}