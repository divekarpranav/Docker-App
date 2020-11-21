using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myWebApp.Pages
{
    public class SubModel : PageModel
    {
        private readonly ILogger<SubModel> _logger;

        public SubModel(ILogger<SubModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
