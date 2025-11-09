# Library Management API

**Problem Statement**  
Model and implement a basic **Library Management System Web API** using **.NET 8**, following clean architecture and OOP principles.  

The system supports managing **Books** and **Members** with CRUD operations through a RESTful API.

---

## Technology Stack

- **Backend:** .NET 8, C#  
- **Database:** SQL Server  
- **ORM:** Entity Framework Core (Code-First)  
- **Design:** Clean Architecture (Domain, Repository, Service, Controller)  
- **API Testing:** Swagger / Postman

---

## Project Structure
LibraryManagement/
├── Api/
│ └── Controllers/ # Web API Controllers for Books and Members
├── Application/
│ ├── DTOs/ # Request/Response DTOs
│ ├── Interfaces/ # Service and Repository interfaces
│ └── Services/ # Business logic / Service layer
├── Domain/
│ └── Entities/ # Core domain models (Book, Member)
├── Infrastructure/
│ ├── Data/ # DbContext
│ └── Repositories/ # Repository implementations
└── README.md


**Note:** Namespace inside code uses `LibraryManagement` even if GitHub repo name differs.

---

## Database Design

**Entities:**

### Book
| Field          | Type       | Description                  |
|----------------|-----------|------------------------------|
| Id             | int       | Primary Key                  |
| Title          | string    | Book title                   |
| Author         | string    | Author name                  |
| ISBN           | string    | Optional                     |
| PublishedYear  | int       | Year of publication          |
| TotalCopies    | int       | Total number of copies       |
| AvailableCopies| int       | Copies available to lend     |
| CreatedAt      | datetime  | Record creation timestamp    |
| UpdatedAt      | datetime  | Record update timestamp      |

### Member
| Field        | Type       | Description                |
|--------------|-----------|----------------------------|
| Id           | int       | Primary Key                |
| FullName     | string    | Member full name           |
| Email        | string    | Member email               |
| PhoneNumber  | string    | Optional                   |
| RegisteredAt | datetime  | Registration timestamp     |
| UpdatedAt    | datetime  | Record update timestamp    |

---

## API Endpoints

### Books
| Method | Endpoint          | Description             |
|--------|-----------------|------------------------|
| GET    | /api/book       | Get all books           |
| GET    | /api/book/{id}  | Get book by ID          |
| POST   | /api/book       | Create new book         |
| PUT    | /api/book       | Update existing book    |
| DELETE | /api/book/{id}  | Delete book             |

### Members
| Method | Endpoint            | Description          |
|--------|-------------------|--------------------|
| GET    | /api/member       | Get all members      |
| GET    | /api/member/{id}  | Get member by ID     |
| POST   | /api/member       | Create new member    |
| PUT    | /api/member       | Update existing member|
| DELETE | /api/member/{id}  | Delete member        |

---

## Setup Instructions

### Prerequisites
- .NET 8 SDK installed
- SQL Server (local, Docker, or Azure)
- EF Core CLI (`dotnet ef`)

### Connection String (appsettings.json)
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=LibraryDB;User Id=sa;Password=P@ssword123;TrustServerCertificate=true;"
  }
}
