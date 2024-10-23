using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public List<Event> Events { get; set; } = new List<Event>();

    [BindProperty]
    public string EventDate { get; set; }

    [BindProperty]
    public string EventDetails { get; set; }

    public void OnGet()
    {
        // Initialize or load any stored events here
    }

    public IActionResult OnPost()
    {
        // Add event to the list
        Events.Add(new Event
        {
            Date = EventDate,
            Details = EventDetails
        });

        return Page();
    }
}

public class Event
{
    public int Id { get; set; }  // Primary Key
    public string Date { get; set; }
    public string Details { get; set; }
}
