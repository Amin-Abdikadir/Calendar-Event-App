# Calendar Event App

This is a simple calendar application that allows users to:
1. Select a date from a calendar.
2. Add an event to the selected date.
3. Store and retrieve the event.
4. Display stored events on the calendar.

## Tech Stack
- Backend: ASP.NET Core with C#
- Frontend: Razor Pages (HTML, C#)
- Database: PostgreSQL
- Deployment: Render (Backend), Netlify (Frontend)
- CI/CD: GitHub Actions for automation of building, testing, and deploying the application.

## Features
- Create, retrieve, and manage calendar events.
- Simple, easy-to-use UI for adding and viewing events.
- Data persistence using PostgreSQL.

## Future Enhancements
- User authentication for personalised events.
- Event reminders via email or notifications.
- Improve calendar design and add additional views.

## Setup
To run this project, you will need to:
1. Clone this repository.
2. Set up PostgreSQL and update the connection string.
3. Run the backend using ASP.NET Core.
4. Serve the frontend using Razor Pages.

## CI/CD
The project includes a GitHub Actions pipeline to automate deployment. The backend is deployed on Render, and the frontend will be deployed on Netlify.

