# ASP.NET MVC CRUD Application using Entity Framework and SQL Server

This repository demonstrates a simple CRUD (Create, Read, Update, Delete) operation using ASP.NET MVC, Entity Framework, and SQL Server.

## 🛠️ Technologies Used

* ASP.NET MVC
* Entity Framework 6
* SQL Server
* Visual Studio
* C#

---

## 📦 Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/your-repo.git
   cd your-repo
   ```

2. **Open the project in Visual Studio.**

3. **Install Entity Framework via NuGet Package Manager Console:**

   ```bash
   Install-Package EntityFramework
   ```

4. **Configure the Database Connection:**

   * Open `Web.config` and update the connection string:

     ```xml
     <connectionStrings>
         <add name="LibraryDBContext" connectionString="Data Source=YourServerName;Initial Catalog=LibraryDB;Integrated Security=True" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

5. **Create the Database and Table:**

   * Open **SQL Server Management Studio (SSMS)** and run the following SQL:

   ```sql
   CREATE DATABASE LibraryDB;
   GO
   USE LibraryDB;
   CREATE TABLE Books (
       Id INT PRIMARY KEY IDENTITY,
       Title NVARCHAR(100),
       Author NVARCHAR(100),
       ISBN NVARCHAR(50)
   );
   ```

---

## 🔧 Database Migrations

1. **Enable Migrations:**

   ```bash
   Enable-Migrations
   ```

2. **Create Initial Migration:**

   ```bash
   Add-Migration InitialCreate
   ```

3. **Update Database:**

   ```bash
   Update-Database
   ```

---

## 🚀 Running the Application

1. **Start the application in Visual Studio:**

   * Press `F5` or `Ctrl + F5`.

2. **Access the CRUD interface:**

   * Navigate to `/Books` to view, add, edit, and delete books.

---

## 📂 Folder Structure

```
/YourProject
│── Controllers
│   └── BooksController.cs
│── Models
│   └── Book.cs
│   └── LibraryDBContext.cs
│── Views
│   └── Books
│       └── Index.cshtml
│       └── Create.cshtml
│       └── Edit.cshtml
│       └── Delete.cshtml
│── Web.config
│── README.md
```

---

## ✅ Features

* Create a new book
* View all books
* Edit a book
* Delete a book
-------

## 💡 Acknowledgments

* ASP.NET MVC Documentation
* Entity Framework Documentation
* SQL Server Documentation
