# ExpenseTracker – ASP.NET Core MVC Application

## 📌 Description
ExpenseTracker is a simple ASP.NET Core MVC web application built to manage daily expenses.
The project demonstrates full CRUD (Create, Read, Update, Delete) operations using Entity Framework Core and Microsoft SQL Server.

This project was developed as a learning project to understand backend development, database integration, and end-to-end web application flow.

---

## 🛠️ Tech Stack
- ASP.NET Core MVC
- C#
- Entity Framework Core
- Microsoft SQL Server (MSSQL)
- Razor Views (CSHTML)
- HTML, CSS
- Visual Studio

---

## ✨ Features
- Add new expense records
- View list of all expenses
- Edit existing expenses
- Delete expenses
- Calculate total expense amount
- Simple and clean UI

---

## 🧩 Project Structure

    ExpenseTracker
    │
    ├── Controllers
    │   └── ExpenseController.cs
    │
    ├── Models
    │   └── Expense.cs
    │
    ├── Data
    │   └── AppDbContext.cs
    │
    ├── Views
    │   └── Expense
    │       ├── Index.cshtml
    │       ├── CreateOrEdit.cshtml
    │       └── ExpensePage.cshtml
    │
    ├── appsettings.json
    └── Program.cs



---

## ⚙️ How to Run the Project
1. Clone the repository  

   git clone https://github.com/reze00800/ExpenseTracker.git


2. Open the project in **Visual Studio**

3. Update the SQL Server connection string in `appsettings.json` if needed

4. Run the following commands in **Package Manager Console**:

       Add-Migration InitialCreate
       Update-Database


5. Press **F5** to run the application

---

## 🎯 Learning Outcomes
- Understanding ASP.NET Core MVC architecture
- Working with Entity Framework Core
- Performing CRUD operations
- Using Razor Views and model binding
- Connecting application with SQL Server database

---

## 👤 Author
**Yash**  
Computer Science Graduate | Fresher Web Developer  
Skilled in ASP.NET Core, C#, MSSQL, and MVC

---

## 📌 Note
This project is created for learning and practice purposes.
