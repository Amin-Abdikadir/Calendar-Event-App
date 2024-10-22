# Project Plan for Calendar Event App

## Objective
Build a simple calendar application where users can:
1. Select a date.
2. Add an event to the selected date.
3. Store the event.
4. Retrieve and display the event.

## Technologies
- **Frontend**: Razor Pages (ASP.NET Core)
- **Backend**: C# with ASP.NET Core
- **Database**: PostgreSQL
- **CI/CD**: GitHub Actions for pipeline automation
- **Deployment**: Netlify (Frontend), Render (Backend)

---

## Step-by-Step Plan

### Step 1: Set Up Repository
- Create a new GitHub repository.
- Configure GitHub Actions for CI/CD.
- Add `README.md` and `PLAN.md`.

### Step 2: Build the Backend (ASP.NET Core)
- Set up a new ASP.NET Core project.
- Create models for events and dates.
- Set up RESTful API endpoints:
  - POST `/events`: Add a new event.
  - GET `/events/{date}`: Retrieve events for a specific date.
  
### Step 3: Integrate PostgreSQL
- Set up PostgreSQL database on Render.
- Create tables for storing event data.
- Implement database migrations in .NET.

### Step 4: Build the Frontend (Razor Pages)
- Set up Razor Pages within the .NET project.
- Create a simple UI for:
  - Selecting dates.
  - Adding events.
  - Viewing events for a selected date.

### Step 5: Connect Frontend to Backend
- Use Razor Pages to call the backend API endpoints.
- Display data in a user-friendly manner.

### Step 6: Implement CI/CD Pipeline
- Set up GitHub Actions for:
  - Running tests (if any).
  - Building the project on every push.
- Automatically deploy the backend to Render.
- Automatically deploy the frontend to Netlify.

### Step 7: Testing and Debugging
- Manually test adding and retrieving events.
- Ensure all frontend and backend interactions work smoothly.

### Step 8: Finalise
- Polish the UI and ensure it works across different devices.
- Document the project in the `README.md`.
- Submit the application.

---

## Future Improvements
- Add user authentication for personalised event management.
- Implement a search feature for events.
- Integrate calendar APIs like Google Calendar for additional features.

