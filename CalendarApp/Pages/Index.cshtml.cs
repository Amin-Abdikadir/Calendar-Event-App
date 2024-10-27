using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using CalendarApp.Data;
using CalendarApp.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

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
                Events = _context.CalendarEvents
                    .Where(e => e.UserId == user.Id)
                    .ToList();
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

            return RedirectToPage();
        }
    }
}
