# Contacts Management API

This is a RESTful API backend for managing contacts, built with .NET Core. It allows users to perform CRUD operations (Create, Read, Update, Delete) on contact records.

## Table of Contents

- [Setup Instructions](#setup-instructions)
- [Prerequisites](#prerequisites)
- [Running the API](#running-the-api)
- [Project Structure](#project-structure)
- [API Endpoints](#api-endpoints)


## Setup Instructions

### Prerequisites

Ensure you have the following installed:

- .NET Core SDK 6.0 or higher
- Visual Studio 2022 or VS Code
- Node.js and npm (optional, for frontend development)

### Running the API

1. **Clone the repository:**

   ```bash
   git clone https://github.com/Saranya178/WebApiContact.git

### Project Structure

Provide an overview of how your project is structured. Mention key directories or modules and their purposes. For example:

```markdown
## Project Structure

The project is organized into the following main components:

- **Controllers:** Contains API controllers for handling HTTP requests.
- **ContactService:** Implements the business logic for managing contacts.
- **Models:** Defines data models used within the application.


### API Endpoints

Document each API endpoint supported by your project, including their URLs, HTTP methods, descriptions, request payloads (if applicable), and response formats. Here’s an example for each endpoint (GET, POST, PUT, DELETE):

```markdown
## API Endpoints

### Get All Contacts

- **URL:** `GET /api/contact`
- **Description:** Retrieves a list of all contacts.
- **Response Example:**

  ```json
  [
    {
      "id": 1,
      "firstName": "John",
      "lastName": "Doe",
      "email": "john.doe@example.com"
    },
    {
      "id": 2,
      "firstName": "Jane",
      "lastName": "Doe",
      "email": "jane.doe@example.com"
    }
  ]

### Get Contact by ID

- **URL:** `GET /api/contact/{id}`
- **Description:** Retrieves a contact by its ID
- **Response Example:**

  ```json
  {
  "id": 1,
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com"
}

###Create a New Contact

- **URL:** `POST /api/contact`
- **Description:** Creates a new contact.
- **Request Example:**

  ```json
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com"
}

- **Response Example:**

  ```json
{
  "id": 3,
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com"
}

###Update an Existing Contact

- **URL:** `PUT /api/contact/{id}`
- **Description:**  Updates an existing contact.
- **Request Example:**

  ```json
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com"
}

- **Response Example:**

  ```json
{
  "id": 3,
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com"
}
###Delete a Contact

- **URL:** `DELETE /api/contact/{id}`
- **Description:**  Deletes a contact by its ID.
- **Response Example:**204 No Content




