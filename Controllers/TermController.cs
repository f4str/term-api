using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TermAPI.Models;

namespace TermAPI.Controllers {
    [Route("term")]
    public class TermController : Controller {

        [Route("current")]
        public IActionResult Current() {
            DateTime date = DateTime.Today;
            Term term = new Term(date);
            return new ObjectResult(term);
        }

    }
}