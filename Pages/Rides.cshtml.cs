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
            Rides.Add(new Ride {
                Title = "Christmas Lunch - 107 Dining Room, Heswall",
                Date = new DateTime(2017, 12, 11),
                StartLocation = "Nets",
                RideLeader = "Alan",
                Level = "D",
                Description = "This is a D- level ride, leaving Net's Café for Xmas lunch"
            });
        }
    }
}