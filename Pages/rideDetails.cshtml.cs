using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WirralWheelers.Pages
{
    public class RideDetailsModel : PageModel
    {
        public Ride Ride { get;set;}

        public void OnGet(int id)
        {
            Ride = RideList.Ride(id);
        }
    }
}
