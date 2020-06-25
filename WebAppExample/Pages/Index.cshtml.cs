using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppExample.Pages {
    public class IndexModel : PageModel {
        public DateTime Date { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel (ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet () {
            Date = DateTime.Now;
        }
    }
}