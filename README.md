---

# 📦 Technical Test – CRUD Orders (.NET)

## 📌 Overview

This repository contains a **Technical Test** developed in **C# with .NET**, focused on building a complete **CRUD system for orders**, applying **clean architecture principles, SOLID guidelines, and design patterns**.

The project simulates a database using **XML files**, from which products and orders are read, inserted, updated, and deleted, allowing structured data management without relying on a relational database.

---

## 🎯 Project Purpose

The main goal of this project is to demonstrate:

* Backend development skills using **.NET**
* Proper **software architecture** and code organization
* Application of **design patterns** and best practices
* Separation of concerns and maintainable code

---

## 🏗️ Architecture & Structure

The solution follows a **layered architecture**, organized to ensure scalability, testability, and clean separation of responsibilities:

```
/Application
  ├── DTOs
  ├── Interfaces
  ├── Services

/Domain
  ├── Entities
  ├── Builders

/Infrastructure
  ├── Repositories
  ├── XMLDataSource

/Presentation
  ├── Controllers / UI
```

### Key Concepts Applied

* **Dependency Injection**
* **Interfaces** for loose coupling
* **DTOs (Data Transfer Objects)**
* **Builder Design Pattern**
* **Layered / Clean Architecture**
* **SOLID Principles**

---

## ⚙️ Main Features

* 📄 XML-based data source (database simulation)
* ➕ Create new orders
* 📦 Insert and store products
* 📋 Read and list orders and products
* ✏️ Update existing records
* ❌ Delete orders and products
* 🔄 Decoupled data handling using DTOs

---

## 🛠️ Technologies Used

* **Language:** C#
* **Framework:** .NET
* **Persistence:** XML files
* **Architecture:** Layered / Clean Architecture
* **Design Patterns:** Builder, Dependency Injection
* **Paradigm:** Object-Oriented Programming (OOP)

---

## 📚 Best Practices

* Clean and readable code
* Single Responsibility Principle
* Low coupling and high cohesion
* Easily scalable to a real database
* Ready for unit testing

---

## 🚀 How to Run the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/JeffersonD9/Technical-Test.git
   ```

2. Open the solution in **Visual Studio**

3. Restore dependencies and run the project

---

## 👨‍💻 Author

**Jefferson Muñoz**
Software Developer
Backend .NET | Node.js | Software Architecture

---
