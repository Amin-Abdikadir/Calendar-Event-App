using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalendarApp.Data;
using CalendarApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http; // Required for session handling

namespace CalendarApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<CalendarEvent> Events { get; set; } = new List<CalendarEvent>();

        [BindProperty]
        public string? EventDate { get; set; } = string.Empty;

        [BindProperty]
        public string? EventTitle { get; set; } = string.Empty;

        [BindProperty]
        public string? EventDetails { get; set; } = string.Empty;

        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                // Load events for logged-in user
                Events = _context.CalendarEvents
                    .Where(e => e.UserId == user.Id)
                    .ToList();
            }
            else
            {
                // Check for session-stored events for anonymous user
                var sessionEvents = HttpContext.Session.GetString("AnonymousEvents");
                if (!string.IsNullOrEmpty(sessionEvents))
                {
                    Events = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CalendarEvent>>(sessionEvents);
                }
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var newEvent = new CalendarEvent
                {
                    Date = DateTime.SpecifyKind(DateTime.Parse(EventDate), DateTimeKind.Utc),
                    Title = EventTitle,
                    Description = EventDetails,
                    UserId = user.Id
                };

                _context.CalendarEvents.Add(newEvent);
                await _context.SaveChangesAsync();
            }
            else
            {
                // Save event in session for anonymous user
                var newEvent = new CalendarEvent
                {
                    Date = DateTime.SpecifyKind(DateTime.Parse(EventDate), DateTimeKind.Utc),
                    Title = EventTitle,
                    Description = EventDetails
                };

                var sessionEvents = HttpContext.Session.GetString("AnonymousEvents");
                var eventsList = string.IsNullOrEmpty(sessionEvents)
                    ? new List<CalendarEvent>()
                    : Newtonsoft.Json.JsonConvert.DeserializeObject<List<CalendarEvent>>(sessionEvents);

                eventsList.Add(newEvent);
                HttpContext.Session.SetString("AnonymousEvents", Newtonsoft.Json.JsonConvert.SerializeObject(eventsList));
            }

            return RedirectToPage();
        }
    }
}




