Student Planner Console Application.
This is a console-based application designed for students to manage their study schedules. The application allows users to add, delete, update, and view events such as study sessions, including details like date, topics, sources, and notes. The application uses Entity Framework and is written in C# with .NET.

Features
Add Event: Add a new study event with details like date, topics, sources, and notes.
Delete Event: Delete an existing event by date.
Update Event: Update the details of an existing event.
View All Events: List all study events.
View Event by Date: View the details of a study event by specifying the date.
Technologies Used
Language: C#
Framework: .NET
ORM: Entity Framework
Database: (PostgreSql)

Getting Started
Prerequisites
You must have the .NET SDK installed on your computer.

Installation
Clone the repository:
git clone https://github.com/yourusername/student-planner-console.git

Navigate to the project directory:
cd student-planner-console

Install the necessary packages:
dotnet restore

Configuration
Update the appsettings.json file with your database connection string:
{
"ConnectionStrings": {
"DefaultConnection": "YourDatabaseConnectionString"
}
}

Apply the migrations to create the database schema:
dotnet ef database update

Running the Application
Run the application using the following command:
dotnet run

Usage
When the application runs, you will be presented with a menu where you can choose from the following options:

Add Event: Enter the details of the study event including date, topics, sources, and notes.
Delete Event: Enter the date of the event you wish to delete.
Update Event: Enter the date of the event you wish to update, then provide the new details.
View All Events: Display all the events stored in the database.
View Event by Date: Enter the date to view the details of the corresponding event.
Exit: Exit the application.
With this configuration, you should be able to use the Student Planner Console Application smoothly.

