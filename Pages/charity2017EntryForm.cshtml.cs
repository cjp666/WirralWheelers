using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WirralWheelers.Pages
{
    public class Charity2017EntryForm : PageModel
    {
        [BindProperty]
        public string FirstRiderFirstName { get; set; } = string.Empty;
        [BindProperty]
        public string FirstRiderSurname { get; set; } = string.Empty;
        [BindProperty]
        public string FirstRiderDob { get; set; } = string.Empty;

        [BindProperty]
        public string SecondRiderFirstName { get; set; } = string.Empty;
        [BindProperty]
        public string SecondRiderSurname { get; set; } = string.Empty;
        [BindProperty]
        public string SecondRiderDob { get; set; } = string.Empty;
        
        public string LeadRiderAddress1 { get; set; }
        public string LeadRiderAddress2 { get; set; }
        public string LeadRiderAddress3 { get; set; }
        public string LeadRiderPostcode { get; set; }
        public string LeadRiderTelephone { get; set; }
        
        public string LeadRiderEmail { get; set; }
        public string LeadRiderEmailConfirm { get; set; }

        public void OnGet()
        {
        }
    }
}
