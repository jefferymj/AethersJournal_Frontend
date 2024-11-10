using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AethersJournal.Pages
{
    public class JournalModel : PageModel
    {
        public List<DateTime>? Dates {get; private set;}
        
        [FromRoute]
        public string? Date {get; set;}
        public void OnGet()
        {
            Dates = new List<DateTime>();
            DateTime startDate = DateTime.Today.AddMonths(-1); 
            DateTime endDate = DateTime.Today; 

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                Dates.Add(date);
            }

            Dates.Reverse();
        }
    }
}
