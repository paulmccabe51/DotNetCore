using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
            throw new ContactException("Contact Exception");
        }
    }

    public class ContactException : Exception
    {
        public ContactException(string message) : base(message) { }
 
    }
}
