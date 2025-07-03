# Logistics Management System (C# | .NET | WinForms)

A Windows desktop application designed to streamline operations for transport service providers. This system enables administrators and customers to manage job orders, transport assignments, and payments with an intuitive and secure interface.

---

## 🚀 Features

### 🔐 Login System
- Role-based login for **Admin** and **Customer**
- Secure credential validation
- Personalized dashboards after login

### 📦 Job Management
- Admin can view, assign, and update customer job requests
- Customers can submit job requests with delivery details

### 🚛 Transport Assignment
- Admin can view available transport units and assign them to jobs
- Dynamic status updates for each transport unit

### 💰 Payment Tracking
- Customers can view pending and completed payments
- Admin can generate and update billing status

### 📊 Reporting
- Dashboard visualizations (e.g., bar charts) for admin analytics
- Track total customers, assigned jobs, and payment stats

---

## 🧱 Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Framework
- **UI:** Windows Forms (WinForms)
- **Architecture:** Multi-layered structure (GUI, Business Logic Layer, Data Layer)
- **Database:** Microsoft SQL Server (connected via ADO.NET)

---

## 🗂️ Project Structure

Here is a clean, professional `README.md` (Markdown) for your system based on the project described in the PDF — adapted for GitHub:

Logistics-Management-System/
├── Component Design/              # UI mockups and component diagrams
├── DFD Diagrams/                  # Data Flow Diagrams for system design
├── E-ShiftSystem/                 # Main application source code (C# WinForms)
├── E-ShiftSystem Database Files/ # SQL Server database and scripts
├── packages/                      # NuGet packages
├── E-ShiftSystem.sln             # Visual Studio solution file
├── LICENSE                        # Project license (MIT)
└── README.md                      # Project documentation


## 🧪 How to Run

1. Clone the repository
2. Open the `.sln` file in **Visual Studio**
3. Ensure **SQL Server** is running and update the connection string in `DAL/db.cs`
4. Build and run the solution

---

## 📌 License

This project is licensed under the [MIT License](LICENSE).

---

## 👨‍💻 Author

Created by **Gishor Thavakumar** as part of an academic assignment to demonstrate full-stack Windows app development using C# and .NET.
