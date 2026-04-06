# 🏋️ FitConnect API - Graduation Project

Welcome to the official repository for **FitConnect**, a modern Fitness Management & Coaching platform. This backend is powered by **.NET 9**, **SQL Server**, and **Docker**.

---

## 🛠️ Tech Stack

| Component             | Technology                              |
| :-------------------- | :-------------------------------------- |
| **Framework**         | .NET 9.0 (Latest)                       |
| **Database**          | Microsoft SQL Server 2022               |
| **Containerization**  | Docker & Docker Compose                 |
| **API Documentation** | Scalar (Modern OpenAPI UI)              |
| **Architecture**      | Clean Architecture / Onion Architecture |

---

## 🚀 Getting Started (First Time Setup)

Follow these steps to get the project running on your local machine:

### 1️⃣ Prerequisites

Ensure you have the following installed:

* [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) (Crucial for development)
* [Docker Desktop](https://www.docker.com/products/docker-desktop/)
* Visual Studio 2022 (Version 17.12 or higher)

---

### 2️⃣ Clone & Setup

```bash
git clone https://github.com/YOUR_USERNAME/FitConnect.git
cd FitConnect
```

---

### 3️⃣ Spin up the Database

We use Docker to keep the database isolated:

```bash
docker-compose up -d db
```

---

### 4️⃣ Run the API

* Open **FitConnect.slnx** in Visual Studio
* Select **http profile** from the debug dropdown
* Press **F5**

The browser will automatically open:
👉 http://localhost:5000/scalar/v1

---

## 🔄 Development Workflow (How to Work)

To ensure smooth collaboration, follow this professional workflow:

### 📡 Step 1: Get Latest Changes (Pull)

Before you start coding, always get the latest updates:

* Visual Studio → **Git Changes** → Click **Pull**

---

### 💻 Step 2: Code & Hot Reload

* **Modify:** Make your changes
* **Save:** `Ctrl + S` (Hot Reload will apply changes automatically 🔥)
* **Test:** Use Scalar UI at `http://localhost:5000`

---

### 💾 Step 3: Save Your Work (Commit)

* Go to **Git Changes**
* Click **Stage All (+)**
* Write a clear message

  > Example: `Add Trainer Registration logic`
* Click **Commit Staged**

---

### 📤 Step 4: Share Your Work (Push)

* Click **Push (↑)** to upload your changes to GitHub

---

## ⚠️ Important Configuration

* **Connection String:**
  The API connects to `localhost:1433`
  ➜ Make sure Docker container is **running**

* **Ports:**
  API runs on: `http://localhost:5000`

* **Database Migrations:**
  If you modify models, run:

```powershell
Update-Database
```


---

## 📌 Notes

* Follow Clean Architecture principles while coding
* Keep commits small and meaningful
* Always pull before starting new work
* Test your endpoints before pushing

---

🔥 Happy Coding!
