using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myWebApp.Pages
{
    public class MulModel : PageModel
    {
        private readonly ILogger<MulModel> _logger;

        public MulModel(ILogger<MulModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
