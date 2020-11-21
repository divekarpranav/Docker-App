using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myWebApp.Pages
{
    public class DivModel : PageModel
    {
        private readonly ILogger<DivModel> _logger;

        public DivModel(ILogger<DivModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
