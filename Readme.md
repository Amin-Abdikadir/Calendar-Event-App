# Calendar Event Application

This is a calendar event application where users can:
1. Select a date.
2. Add an event to the selected date.
3. Store the event in a PostgreSQL database.
4. Retrieve and display events.

The project is built using ASP.NET Core (Razor Pages), with a PostgreSQL database for data storage. The application is deployed using Render for the backend, and the CI/CD pipeline is managed through GitHub Actions.

## Features

* **Event Management**: Users can create events with a title and description for specific dates.
* **User Authentication**: Registered users can securely manage their events. Anonymous users can add events with a warning that their data might be lost unless they register.
* **Session Management**: Allows anonymous users to temporarily store events within their session.
* **PostgreSQL Integration**: Persistent storage of events in a PostgreSQL database.
* **CI/CD Pipeline**: Automated testing, building, and deployment using GitHub Actions.
* **Database Security Enhancements**: Improved security settings to restrict database access and prevent unauthorised connections.

## Installation

### Prerequisites

* .NET 6 SDK
* PostgreSQL
* Git

### Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/Amin-Abdikadir/Calendar-Event-App.git
   cd Calendar-Event-App

**Create a PostgreSQL database**
 named  `calendarapp_db`, or adjust the connection string in  `appsettings.json`  to match your environment:

    `"ConnectionStrings": {
      "DefaultConnection": "Host=your-db-host;Database=calendarapp_db;Username=your-username;Password=your-password"
    }` 
    
Run the following commands:
    
    `dotnet restore
    dotnet run` 
    
You should now be able to access the app at `https://localhost:5001`.

## CI/CD Pipeline

The project includes a GitHub Actions workflow for continuous integration and deployment. Each push to the  `main`branch triggers automated tests and builds the project. If successful, the app is deployed to Render.

## Project Management

A project board was utilised to create and track tickets for each task, ensuring organised progress and milestone completion. You can view the project board  [here](https://github.com/users/Amin-Abdikadir/projects/5).

## Deployment

-   **Backend**: Deployed on Render, which provides seamless PostgreSQL integration and hosting.
-   **Frontend**: Embedded within the ASP.NET Core project for simplicity, with potential future plans to split it and deploy on a service like Netlify.

## Recent Updates

-   **User Registration and Authentication**: Added secure user registration, enabling personalised event management.
-   **Anonymous User Session**: Enabled temporary event storage with a warning message for unregistered users.
-   **Database Security**: Enhanced access control settings to prevent unauthorized connections.
-   **Deployment Improvements**: Resolved deployment-related issues to ensure smoother functionality on Render.

## Future Plans

-   Add functionality to edit and delete events.
-   Integrate with Google Calendar for external calendar syncing.
-   Enhance the overall design and UX for better user experience.
-   Expand the current session management features to include longer-term data persistence for anonymous users.