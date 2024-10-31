
# PLAN.md

## **Step 1: Initial Project Setup**

-   ✅ Created the GitHub repository and organised the development process with a project board.
-   ✅ Used GitHub Projects for ticket management to stay organised and track progress effectively.

## **Step 2: Backend Development**

-   ✅ Built foundational models to represent calendar events.
-   ✅ Integrated  **PostgreSQL**  for data storage, ensuring reliable data persistence and implemented necessary database migrations.
-   ✅ Set up the backend using  **ASP.NET Core**  with  **Razor Pages**  to keep things simple yet robust.
-   ✅ Developed API endpoints:
    -   `POST /events`: For adding new events.
    -   `GET /events/{date}`: For retrieving events based on the date.

## **Step 3: Frontend Implementation**

-   ✅ Constructed the user interface using  **Razor Pages**  for seamless integration.
-   ✅ Focused on creating an intuitive interface for:
    -   Selecting event dates.
    -   Adding new events.
    -   Displaying stored events in a clear, user-friendly manner.
-   ✅ Used  **Bootstrap 5**  for a responsive, modern look that adapts to various screen sizes.

## **Step 4: Connecting Frontend and Backend**

-   ✅ Ensured smooth communication between the frontend and backend so that event data flows seamlessly.
-   ✅ Verified that data retrieved and displayed was correct, with special attention to real-time interactions and updates.

## **Step 5: Security Measures**

-   ✅ Implemented necessary restrictions on database access to prevent unauthorised access, following concerns raised regarding potential database vulnerabilities.
-   ✅ Ensured that only trusted connections could access the database by adjusting access control settings and security configurations on  **Render**.

## **Step 6: CI/CD Pipeline Setup**

-   ✅ Configured  **GitHub Actions**  for an automated CI/CD pipeline to:
    -   Build and package the project.
    -   (In the future) run automated tests as they're developed.
    -   Deploy the app to  **Render**  for hosting.
-   ✅ Deployed the backend and frontend together on  **Render**  to simplify deployment and reduce complexity.

## **Step 7: Enhancements and Additions**

-   ✅ Added user registration and authentication capabilities to enable users to manage their events securely.
-   ✅ Implemented session management for anonymous users, allowing them to add events with a warning about potential data loss if they don’t register.
-   ✅ Enhanced UI components to handle feedback messages for user actions, improving the user experience.
-   ✅ Cleared up warnings and fixed minor issues based on feedback and further testing.

## **Ongoing Work: Testing**

-   ❗ Current limitation: No automated testing has been implemented yet outside of manual tests.
-   ⚙️ Ongoing task: Setting up and writing unit tests to improve project reliability and catch potential issues early.

## **Achievements to Date**

-   ✅ Successfully deployed the app to  [Render](https://calendar-event-app.onrender.com/), where it's fully functional and live.
-   ✅ Integrated  **PostgreSQL**  for persistent storage and ensured database security.
-   ✅ Created a streamlined development process with the help of  **GitHub Actions**  for CI/CD.
-   ✅ Used  **GitHub Projects**  to break down tasks and maintain a clear, agile workflow.

## **Future Plans**

-   **Complete Unit Testing**: Implement comprehensive unit tests to cover core functionalities.
-   **Event Editing & Deletion**: Expand the current app to support editing and deleting existing events.
-   **User-Specific Enhancements**: Enhance the user experience with better notifications and controls.
-   **Integration with Google Calendar**: Allow syncing with Google Calendar for better event management.
-   **UI/UX Improvements**: Continuously refine the user interface for smoother navigation and interaction.



