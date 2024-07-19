
# Task Management API

This is a Task Management API built with ASP.NET Core that allows you to manage tasks and employees.

## Features

- Manage tasks: Create, read, update, and delete tasks.
- Associate tasks with employees.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger

## Setup and Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/your-username/task-management-api.git
   cd task-management-api
   ```

2. **Configure the database connection:**

   Update the connection string in `appsettings.json`:

   ```json
   "ConnectionStrings": {
       "sqlConnection": "Your SQL Server connection string here"
   }
   ```

3. **Install dependencies:**

   ```bash
   dotnet restore
   ```

4. **Apply migrations:**

   ```bash
   dotnet ef database update
   ```

5. **Run the application:**

   ```bash
   dotnet run
   ```

   The API will be available at `https://localhost:5001`.

## Usage

Use Postman or any other API client to interact with the API.

### Add a New Task

- **Endpoint:** `POST /api/tasks`
- **Body:**

  ```json
  {
      "title": "New Task",
      "description": "This is a new task",
      "dueDate": "2024-12-31T00:00:00",
      "isCompleted": false,
      "attachments": "attachment1.png",
      "notes": "Some notes",
      "employeeId": 1
  }
  ```

### Get All Tasks

- **Endpoint:** `GET /api/tasks`

### Get Task By ID

- **Endpoint:** `GET /api/tasks/{id}`

### Update a Task

- **Endpoint:** `PUT /api/tasks/{id}`
- **Body:**

  ```json
  {
      "id": 1,
      "title": "Updated Task",
      "description": "This task has been updated",
      "dueDate": "2024-12-31T00:00:00",
      "isCompleted": true,
      "attachments": "updated_attachment.png",
      "notes": "Updated notes",
      "employeeId": 1
  }
  ```

### Delete a Task

- **Endpoint:** `DELETE /api/tasks/{id}`

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License.
