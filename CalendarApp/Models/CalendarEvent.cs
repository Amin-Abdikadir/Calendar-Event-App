using System;
using System.ComponentModel.DataAnnotations;

namespace CalendarApp.Models
{
    public class CalendarEvent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
