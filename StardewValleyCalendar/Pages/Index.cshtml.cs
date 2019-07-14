using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StardewValleyCalendar.Models;
using StardewValleyCalendar.Services;

namespace StardewValleyCalendar.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public IActionResult OnGet()
        {
            return RedirectToPage("Spring");
        }
    }
}
