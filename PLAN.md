### **Step 1: Set Up the Repository**

*   ✅ Create the GitHub repository and establish a project board to organise the development process.
    
*   ✅ Use GitHub Projects for ticket management, allowing for smooth tracking of milestones and task completion.
    

### **Step 2: Backend Development**

*   ✅ Create models representing calendar events.
    
*   ✅ Develop RESTful API endpoints:
    
    *   POST /events: To add a new event.
        
    *   GET /events/{date}: To retrieve events by date.
        
*   ✅ Integrate **PostgreSQL** for data persistence, handling all database interactions and migrations.
    

### **Step 3: Frontend Development**

*   ✅ Build the frontend using **Razor Pages**, ensuring seamless integration with the backend.
    
*   ✅ Design the user interface for:
    
    *   Selecting dates.
        
    *   Adding events.
        
    *   Viewing stored events.
        
*   ✅ Use **Bootstrap 5** to create a modern, responsive design.
    

### **Step 4: Connect Frontend and Backend**

*   ✅ Ensure the frontend communicates effectively with the backend using API calls.
    
*   ✅ Verify that the correct data is displayed promptly and accurately.
    

### **Step 5: CI/CD Pipeline**

*   ✅ Configure **GitHub Actions** for:
    
    *   Building the project.
        
    *   Running tests (if applicable).
        
    *   Deploying the backend to **Render**.
        
*   Potential future deployment of the frontend to **Netlify** may be considered, but for simplicity, both are currently deployed together on Render.
    

Achievements
------------

*   ✅ Deployed the backend to [Render](https://calendar-event-app.onrender.com), where it’s live and ready for use.

    
*   ✅ Implemented **PostgreSQL** for persistent data storage and deployed the app's backend on **Render**.
    
*   ✅ Set up a **GitHub Actions** CI/CD pipeline to automate the build, testing, and deployment processes.
    
*   ✅ Managed development tasks using GitHub Projects to ensure work was broken down into manageable tasks.
    

Future Features
---------------

Several enhancements and new features are planned for the app's future development:

*   **User Authentication:** To allow users to log in and manage their events.
    
*   **Event Editing & Deletion:** Giving users the ability to modify or delete events they've created.
    
*   **Google Calendar Integration:** Syncing with Google Calendar for more robust event management capabilities.
    
*   **UI/UX Enhancements:** Further refining the design to improve the user experience.


