using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITOrganisations.Models;

namespace ITOrganisations.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ITOrganizations()
        {
            List<string> c = new List<string>();
            
            c.Add ( "Microsoft www.microsoft.com " );
            c.Add( "CTS  www.cognizant.com" );
            c.Add(  "Google" );
            c.Add( "Amazon" );
            c.Add(  "TCS" );
            
            return View(c);
        }
    }
}
