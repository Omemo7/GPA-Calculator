# GPA Calculator & Planner 🎓

A specialized desktop application designed to assist students in navigating their academic roadmap. Unlike simple calculators, this tool integrates specific **Major** requirements to track academic progress, manage course loads (Taken/Dropped), and forecast future GPA scenarios.

## 🏗 System Architecture

The application is engineered using a robust **3-Tier Architecture** to separate the calculation logic from data management:

* **Presentation Layer:** A Windows Forms interface for managing course lists and viewing academic summaries.
* **Business Logic Layer (BLL):** Contains the core algorithms for weighing grades, excluding dropped courses from calculations, and validating major requirements.
* **Data Access Layer (DAL):** Utilizes **ADO.NET** for high-performance, raw SQL interactions to retrieve and store course catalogs and student records.

## 🚀 Key Features

### 📊 Advanced GPA Calculation
* **Status-Based Logic:** Intelligent calculation that distinguishes between **Taken**, **Dropped**, and **In-Progress** courses to ensure accurate cumulative averages.
* **Major-Specific Weighting:** Calculates GPA based on the specific credit hour requirements of the selected Major.

### 🗺️ Academic Roadmap
* **Subject Tracking:** precise management of the student's history, allowing them to log passed subjects and identify courses that were withdrawn/dropped.
* **Future Planning:** Capabilities to list "Required" subjects that haven't been taken yet, helping students plan upcoming semesters to meet graduation criteria.

### 📚 Curriculum Management
* **Course Catalog:** A database of available subjects linked to specific Majors.
* **Credit Hour Management:** Tracks total hours completed versus hours remaining for the degree.

## 🛠 Tech Stack

* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Data Access:** ADO.NET (Raw SQL)
* **Database:** MS SQL Server
* **Architecture:** 3-Tier (N-Tier)

