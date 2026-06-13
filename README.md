# 🏥 PriMiClinic - Clinic Management System

PriMiClinic is a web-based Clinic Management System developed using ASP.NET Core MVC, Entity Framework Core, and MySQL. The application is designed to help clinic staff manage daily operations efficiently, including doctor records, patient records, and appointment scheduling.

This system is intended to be operated by the **Receptionist/Admin only**, ensuring centralized management of clinic activities and records.

---

## 📌 Project Description

Managing clinic records manually can be time-consuming and prone to errors. PriMiClinic provides a digital solution that allows the Receptionist/Admin to:

- Maintain doctor information
- Maintain patient records
- Schedule appointments
- Track appointment status
- View clinic statistics

The system improves accuracy, reduces paperwork, and streamlines clinic workflows.

---

## ✨ Features

### 🔐 Authentication Module
- User Registration
- User Login
- Logout Functionality
- Authorization and Protected Pages
- Session-Based Authentication

### 👨‍⚕️ Doctor Management
- Add Doctor
- View Doctor List
- Edit Doctor Details
- Delete Doctor
- Manage Doctor Specialization

### 🧑‍🤝‍🧑 Patient Management
- Add Patient
- View Patient List
- Edit Patient Details
- Delete Patient

### 📅 Appointment Management
- Schedule New Appointments
- View Appointment List
- Prevent Duplicate Appointments
- Appointment Status Tracking
  - Pending
  - Confirmed
  - Completed
  - Cancelled
- Doctor Name with Specialization Display

### 📊 Dashboard
- Total Doctors Count
- Total Patients Count
- Total Appointments Count
- Today's Appointments Count

---

## 👤 User Role

### Receptionist / Admin

The current version of PriMiClinic is designed to be handled entirely by the Receptionist or Administrator.

The Receptionist/Admin can:

✅ Manage Doctors

✅ Manage Patients

✅ Schedule Appointments

✅ Update Appointment Status

✅ View All Appointments

✅ Access Dashboard Statistics

### Doctor Access

Doctor login and self-service functionality are not implemented in the current version.

All operations are managed by the Receptionist/Admin from a single dashboard.

---

## 🛠️ Technology Stack

### Frontend
- HTML5
- CSS3
- Bootstrap 5
- Razor Views

### Backend
- ASP.NET Core MVC
- C#

### Database
- MySQL

### ORM
- Entity Framework Core

### Authentication
- ASP.NET Core Identity

### Reporting
- EPPlus (Excel Export)

### Development Tools
- Visual Studio 2022
- Git & GitHub

---

## 🗄️ Database Structure

### Doctors Table
| Field | Description |
|---------|------------|
| Id | Doctor ID |
| Name | Doctor Name |
| Specialization | Doctor Specialization |

### Patients Table
| Field | Description |
|---------|------------|
| Id | Patient ID |
| Name | Patient Name |
| Age | Patient Age |
| Gender | Patient Gender |
| Contact | Contact Number |

### Appointments Table
| Field | Description |
|---------|------------|
| Id | Appointment ID |
| DoctorId | Selected Doctor |
| PatientId | Selected Patient |
| AppointmentDate | Appointment Date |
| Status | Appointment Status |

---

## 🚀 Installation Guide

### Clone Repository

```bash
git clone https://github.com/your-username/PriMiClinic.git
```

### Open Project

Open the project using:

```text
Visual Studio 2022
```

### Restore Packages

```bash
dotnet restore
```

### Configure Database

Update the connection string in:

```json
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=primiclinicdb;user=root;password=yourpassword;"
}
```

### Apply Migrations

```bash
dotnet ef database update
```

### Run Application

```bash
dotnet run
```

Application will start at:

```text
https://localhost:xxxx
```

---

## 📂 Project Structure

```text
PriMiClinic
│
├── Controllers
│   ├── AccountController
│   ├── DoctorController
│   ├── PatientController
│   ├── AppointmentController
│   └── HomeController
│
├── Models
│   ├── Doctor
│   ├── Patient
│   ├── Appointment
│   └── ApplicationUser
│
├── Views
│   ├── Doctor
│   ├── Patient
│   ├── Appointment
│   ├── Account
│   └── Home
│
├── Data
│   └── ApplicationDbContext
│
└── wwwroot
```

---

## 📋 System Workflow

1. Receptionist/Admin logs into the system.
2. Doctor records are maintained.
3. Patient records are maintained.
4. Appointments are scheduled.
5. Appointment status is updated when required.
6. Dashboard displays clinic statistics.

---

## 🔮 Future Enhancements

- Doctor Portal
- Patient Portal
- Online Appointment Booking
- Email Notifications
- SMS Appointment Reminders
- PDF Report Export
- Advanced Search and Filtering
- Role-Based Access Control

---

## 🎯 Learning Outcomes

This project demonstrates:

- ASP.NET Core MVC Architecture
- Entity Framework Core
- CRUD Operations
- Authentication & Authorization
- Database Management
- Razor Views
- Bootstrap UI Design

---

## 📷 Screenshots

Add screenshots of:

- Login Page
- Dashboard
- Doctor Management
- Patient Management
- Appointment Management

---

## 👨‍💻 Developed By

**Bhumi Ranipa**

ASP.NET Core MVC | C# | MySQL | Entity Framework Core

---

## 📄 License

This project is developed for educational and academic purposes.