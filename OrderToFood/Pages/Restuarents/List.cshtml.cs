using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OrderToFood.Pages.Restuarents
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public void OnGet()
        {

        }
    }
}
