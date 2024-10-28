Calendar Event Application

This is a simple calendar event application where users can:
1. Select a date.
2. Add an event to the selected date.
3. Store the event in a PostgreSQL database.
4. Retrieve and display the event.
The project is built using ASP.NET Core (Razor Pages), with a PostgreSQL database for data storage. The application is deployed using Render for the backend, and the CI/CD pipeline is handled by GitHub Actions.
Features

* Event Management: Users can create events with a title and description for specific dates.
* PostgreSQL Integration: Events are stored persistently in a PostgreSQL database.
* CI/CD Pipeline: Automated testing, building, and deployment using GitHub Actions.
Installation

Prerequisites

* .NET 6 SDK
* PostgreSQL
* Git
git clone https://github.com/Amin-Abdikadir/Calendar-Event-App.gitcd Calendar-Event-App
I created a PostgreSQL database called calendarapp_db. You’ll need to do the same, or you can adjust the connection string in appsettings.json to fit your environment.jsonCopy code"ConnectionStrings": { "DefaultConnection": "Host=your-db-host;Database=calendarapp_db;Username=your-username;Password=your-password"}
bashCopy codedotnet restoredotnet run You should now be able to access the app at https://localhost:5001.
CI/CD Pipeline

I've set up GitHub Actions for continuous integration and deployment. Every time I push new changes to the mainbranch, GitHub Actions runs automated tests and builds the project. If everything passes, the app is automatically deployed to Render.
GitHub Project & Tickets

To manage this project, I used GitHub’s built-in project management board to create and track tickets for each task. You can check out the project board and see how everything was broken down here. This helped me stay organised and ensure I hit every milestone.
Deployment

* Backend: Deployed to Render, which offers easy PostgreSQL integration and free hosting.
* Frontend: The frontend is embedded within the same ASP.NET Core project for simplicity. In the future, I may consider splitting it out and deploying to a service like Netlify.
Future Plans

Here are some ideas for future improvements:
* Add user authentication so that users can manage their own events.
* Include the ability to edit and delete events.
* Integrate with Google Calendar to provide sync functionality for external calendars.
* Enhance the overall design and UX for a better user experience.
