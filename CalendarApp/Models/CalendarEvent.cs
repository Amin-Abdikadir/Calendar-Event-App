using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CalendarApp.Models
{
    public class CalendarEvent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;  // Default value to avoid warning

        [Required]
        public string Description { get; set; } = string.Empty;  // Default value to avoid warning

        [Required]
        public DateTime Date { get; set; }

        public string? UserId { get; set; }  // Nullable foreign key
        public IdentityUser? User { get; set; }  // Nullable association to the user
    }
}


