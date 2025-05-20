# PROG7311-POEPART2

1. Database Development and Integration
📦 Tool: SQL Server / LocalDB
I will create two tables:

🔹 Farmers
[Key]
public int FarmerID { get; set; }
[Required]
public string FarmerName { get; set; }
[Required]
public string Email { get; set; }
[Required]
public int Number {  get; set; }
[Required]
public string Location { get; set; }

🔹 Employee
[Key]
public int EmployeeID { get; set; }
[Required]
public string Name { get; set; }
[Required]
public string Product { get; set; }
[Required]
public DateTime Date { get; set; }
[Required]
public int Price { get; set; }

2. User Role Definition and Authentication
👤 Roles:
Farmer: Adds and views their own products.

Employee: Adds new farmers and views/filters all products.

🔐 Authentication Options:
ASP.NET Identity (Recommended for real apps)

Supports password hashing, registration, login, and role management.

Custom Simple Login (For learning/demo purposes)

Store hashed passwords and manually check them during login.

🔀 After Login:
Redirect to:

Farmer Dashboard (if Role = Farmer)

Employee Dashboard (if Role = Employee)

3. Functional Features
👨‍🌾 Farmer Portal
Can add new products

Can only see their own products

👨‍💼 Employee Portal
Can add new farmers

Can view all products, with filters:

Date Range (e.g., from Jan 1 to Jan 31)

Product Type (e.g., only "Fruits")

Farmer Name (e.g., filter by a specific farmer)

4. User Interface & Usability
📄 Use:
Razor Pages or ASP.NET MVC

Both are ASP.NET web frameworks.

Bootstrap for styling

Makes your UI responsive (works on phones/tablets)

💻 Pages to Create:
Login Page

Farmer Dashboard

Add Product Form

View My Products

Employee Dashboard

Add Farmer Form

View All Products + Filtering

