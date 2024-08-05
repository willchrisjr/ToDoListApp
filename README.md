# To-Do List Application


## Description

This To-Do List application is a robust task management system built using ASP.NET Core MVC. It's designed to help users organize their daily tasks, improve productivity, and maintain a clear overview of their responsibilities.

Key aspects of the application include:

1. **User-Friendly Interface**: The application features a clean, intuitive interface that allows users to quickly add, view, and manage their tasks without any learning curve.

2. **CRUD Functionality**: Users can Create, Read, Update, and Delete to-do items, providing full control over their task list.

3. **Task Prioritization**: Each to-do item includes a title and a completion status, allowing users to easily track which tasks are finished and which are still pending.

4. **Persistent Storage**: The application uses a SQLite database to store tasks, ensuring that user data is preserved between sessions and application restarts.

5. **Responsive Design**: Built with Bootstrap, the application is fully responsive and works seamlessly across desktop and mobile devices.

6. **Scalable Architecture**: Developed using ASP.NET Core MVC, the application follows a modular, scalable architecture that can be easily extended with additional features in the future.

7. **Modern Web Technologies**: The project leverages the power of ASP.NET Core, Entity Framework Core, and modern C# features, making it a great example of contemporary web development practices.



## Features
- View all to-do items
- Add new to-do items
- Edit existing to-do items
- Mark items as completed
- Delete to-do items
- View details of individual to-do items

## Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQLite Database
- C#
- HTML/CSS
- Bootstrap

## Prerequisites
- .NET SDK (version 6.0 or later)
- Visual Studio Code or any preferred IDE

## Installation and Setup
1. Clone the repository:
git clone https://github.com/willchrisjr/ToDoListApp.git

2. Navigate to the project directory:
cd ToDoListApp

3. Restore the required packages:
dotnet restore

4. Apply the database migrations:
dotnet ef database update


## Running the Application
1. In the project directory, run:
dotnet run

2. Open a web browser and navigate to `http://localhost:5095` (or the port number shown in your terminal).

## Project Structure
- `Controllers/`: Contains the application's controllers, including `HomeController.cs` and `ToDoItemsController.cs`
- `Models/`: Contains the data models, including `ToDoItem.cs` and `ToDoContext.cs`
- `Views/`: Contains the application's views, organized by controller
- `Migrations/`: Contains database migration files
- `wwwroot/`: Contains static files like CSS and JavaScript

## Database
This application uses SQLite as its database. The database file (`todo.db`) is created in the project root directory when you run the migrations.



