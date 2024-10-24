using System;
using Xunit;
using CalendarApp.Models;

namespace CalendarApp.Tests
{
    public class CalendarEventTests
    {
        [Fact]
        public void AddEvent_ShouldSaveEventWithCorrectDetails()
        {
            // Arrange
            var newEvent = new CalendarEvent
            {
                Title = "Test Event",
                Description = "This is a test event.",
                Date = DateTime.Now
            };

            // Act & Assert
            Assert.Equal("Test Event", newEvent.Title);
            Assert.Equal("This is a test event.", newEvent.Description);
            Assert.Equal(DateTime.Now.Date, newEvent.Date.Date); // Only compare the date part
        }
    }
}