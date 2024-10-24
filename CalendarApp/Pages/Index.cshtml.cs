using CalendarApp.Data;
using CalendarApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace CalendarApp.Pages  // Add the correct namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<CalendarEvent> Events { get; set; }

        [BindProperty]
        public string EventDate { get; set; }

        [BindProperty]
        public string EventTitle { get; set; }

        [BindProperty]
        public string EventDetails { get; set; }

        public void OnGet()
        {
            // Load events from the database
            Events = _context.CalendarEvents.ToList();
        }

        public IActionResult OnPost()
        {
            var newEvent = new CalendarEvent
            {
                Date = DateTime.SpecifyKind(DateTime.Parse(EventDate), DateTimeKind.Utc),
                Title = EventTitle,
                Description = EventDetails
            };

            _context.CalendarEvents.Add(newEvent);
            _context.SaveChanges();  // Save event to the database

            return RedirectToPage();
        }
    }
}
