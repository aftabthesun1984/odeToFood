using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ode2Food.Services;

namespace ode2Food.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter{ get; set; }
        public string CurrentGreeting { get; set; }
        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public void OnGet()
        {
            CurrentGreeting = _greeter.greetingsOfTheDay();
        }
    }
}
