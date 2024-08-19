# Inventory Management System

## Overview
This Inventory Management System is a Windows Forms application built using C#. It provides functionalities for managing products, categories, users, and customers, along with user authentication 

## Features
- **User Authentication**: Secure login for administrators and customers.
- **Product Management**: Add, edit, delete, and view products.
- **Category Management**: Manage product categories for better organization.
- **User Management**: Manage users with different roles and permissions.
- **Customer Login**: Separate login for customers to access the system.


## Installation
1. **Clone the repository**:
   ```sh
   git clone https://github.com/Tamil7n/InventoryManagementSystem.git
   ```
2. **Open the solution**:
   Open the `.sln` file in Visual Studio.
   
3. **Restore NuGet Packages**:
   Go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution` and restore any missing packages.

4. **Build the project**:
   Build the solution in Visual Studio to restore dependencies and compile the code.

5. **Set up the database**:
   - Create a SQL Server database.
   - Execute the provided SQL script (`DatabaseScript.sql`) to create necessary tables and seed initial data.
   - Update the connection string in `App.config` or `appsettings.json` (depending on your project setup).

6. **Run the application**:
   Start the application from Visual Studio (`F5` or `Ctrl + F5`).

## Modules

### 1. **Login**
   - Admin Login: Secure login for administrators with role-based access control.
   - Customer Login: Separate login for customers to view their orders and details.

### 2. **Products**
   - Add New Products
   - Edit Existing Products
   - Delete Products
   - View Product List

### 3. **Categories**
   - Add New Categories
   - Edit Categories
   - Delete Categories
   - View Category List

### 4. **Users**
   - Add New Users (Admins )
   - Manage User Roles and Permissions
   - Edit User Information
   - Deactivate/Activate Users

### 5. **Customers**
   - Manage Customer Information
   - View Customer Orders
   - Customer Self-Registration and Management



## Dependencies
- **.NET Framework**
- **SQL Server**







