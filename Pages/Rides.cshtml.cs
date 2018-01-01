using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WirralWheelers.Pages
{
    public class RidesModel : PageModel
    {
        public List<Ride> Rides = new List<Ride>();

        public void OnGet()
        {
            Rides = RideList.Current().ToList();
        }
    }
}