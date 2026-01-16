# 📧 Email Confirmation Demo – ASP.NET Core (.NET 8)

🚀 This repository contains a **clean and beginner-friendly ASP.NET Core project** that demonstrates **Email Sending and Basic Email Confirmation** using **Gmail SMTP**.

The goal of this project is to help **students, freshers, and junior developers** understand how **email confirmation works in real-world enterprise applications** and how companies securely send emails using **App Passwords**.

---

## 🏢 About the Repository

This repository is created as a **learning-focused and production-inspired project**.  
It follows **clean coding practices**, **service-based architecture**, and **secure email configuration**, making it suitable for:

- 🎓 Students learning ASP.NET Core  
- 👨‍💻 Freshers preparing for interviews  
- 🏢 Understanding real companies-level email workflows  

---

## ✨ Key Features

✅ Send email using Gmail SMTP  
✅ Clean service-based architecture  
✅ Beginner friendly & well-structured  
✅ Uses **.NET 8 (Latest LTS)**  
✅ Easy configuration with `appsettings.json`  
✅ Perfect for learning **Email Confirmation Flow**
  

---

## 🛠️ Language & Technologies Used (With Versions)

| Technology | Version | Description |
|---------|--------|-------------|
| ⚙️ ASP.NET Core | .NET 8 | Web framework |
| 🧠 C# | C# 12 | Programming language |
| 🌐 .NET SDK | 8.0 | Runtime |
| 📬 SMTP Server | Gmail SMTP | Email sending |
| 🏗️ Dependency Injection | Built-in DI | Clean architecture |

---

## 📂 Repository Structure

```plaintext
EmailDemo.BasicConfirmation
│
├── Services
│ ├── Interfaces
│ │ └── IEmailService.cs
│ └── EmailService.cs
│
├── Program.cs
├── appsettings.json
├── EmailDemo.BasicConfirmation.csproj
└── EmailDemo.BasicConfirmation.sln
```
---

## ⚙️ Email Confirmation Flow

1️⃣ User triggers an email action  
2️⃣ Application prepares email content  
3️⃣ Gmail SMTP sends the email securely  
4️⃣ User receives confirmation email  

📌 This flow is commonly used in:
- User Registration
- Email Verification
- Forgot Password
- Account Activation

---

## 🚀 How to Run the Project (Step-by-Step)

### ✅ Prerequisites

- ✔️ Visual Studio 2022 or later  
- ✔️ .NET 8 SDK installed  
- ✔️ Gmail account with **2-Step Verification enabled**  

---

### ▶️ Steps to Run

1️⃣ Extract the project ZIP file  

2️⃣ Open `EmailDemo.BasicConfirmation.sln` in **Visual Studio**

3️⃣ Restore NuGet packages  
4️⃣ Configure email settings in `appsettings.json`

```json
"EmailSettings": {
  "FromEmail": "yourgmail@gmail.com",
  "AppPassword": "your_app_password",
  "Host": "smtp.gmail.com",
  "Port": 587
}
```
5️⃣ Run the project ▶️ Press F5 or Ctrl + F5

---

### 🖼️ Project Output Screenshots (SS)
