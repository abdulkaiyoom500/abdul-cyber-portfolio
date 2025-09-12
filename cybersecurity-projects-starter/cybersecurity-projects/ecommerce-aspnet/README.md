# Mr.Robot E‑Commerce — ASP.NET Core (Razor Pages)

A full-stack e‑commerce demo built for the **Internet Programming** module.  
Features product catalog, search, shopping cart, and an admin panel for CRUD.  
Authentication/Authorization is handled by **ASP.NET Core Identity** (Razor Pages UI).

> This package excludes the *ConsoleApp1adminpasswordreset* project per request.

## ✨ Features

- **Authentication / Roles**
  - Register & Login via ASP.NET Core Identity.
  - First registered account is assigned the **Admin** role automatically (role is created if missing).
- **Catalog & Search**
  - Browse **Products**, view **Product detail**, search by name/description/category.
- **Shopping Cart**
  - Add to cart, update quantities, remove items.
- **Admin**
  - **AdminProducts** page to list/manage products.
  - **addProduct** page to add or update products.
- **UI**
  - Bootstrap layout in `_Layout.cshtml` with shared header/footer.

## 🧰 Tech Stack

- **.NET 8** / **ASP.NET Core** (Razor Pages)
- **Entity Framework Core** (Migrations included)
- **SQL Server LocalDB** by default (edit `appsettings.json` to change provider)
- **ASP.NET Core Identity** (Areas/Identity)

## 📁 Project Structure

```
E-Commerce/
├─ E-Commerce.csproj
├─ Program.cs
├─ appsettings.json
├─ Areas/Identity/...
├─ Models/...
├─ Migrations/...
├─ Pages/
│  ├─ Products(.cshtml/.cs), Product(.cshtml/.cs), Cart(.cshtml/.cs)
│  ├─ Search/...
│  ├─ AdminProducts(.cshtml/.cs), addProduct(.cshtml/.cs)
│  └─ Shared/_Layout.cshtml
└─ wwwroot/
   ├─ css/
   ├─ js/
   └─ images/
```
(If present, the solution file is `E-Commerce.sln`.)

## 🚀 Getting Started

### Prerequisites
- **.NET 8 SDK**
- **SQL Server LocalDB** (Windows) or SQL Server Express/Server

### 1) Restore & Build
```bash
dotnet restore "E-Commerce.sln"
dotnet build "E-Commerce.sln"
```

### 2) Apply Migrations (create the DB)
```bash
dotnet tool install --global dotnet-ef  # if not installed
dotnet ef database update --project "E-Commerce/E-Commerce.csproj"
```

### 3) Run
```bash
dotnet run --project "E-Commerce/E-Commerce.csproj"
# Opens on https://localhost:xxxx or http://localhost:xxxx
```

### 4) Sign in / Admin
Create the **first account** at `/Identity/Account/Register` → it becomes **Admin** automatically.

## 🔎 Notes
- Store real secrets outside `appsettings.json` (User Secrets or env vars) for production.
- Images live under `wwwroot/images`. Adjust page paths as needed.
- You can switch to SQLite by changing the EF provider in `Program.cs` and connection strings.

## 📄 License
© 2025 Mohamed Abdul Kaiyoom — All rights reserved.  
This repository is provided for portfolio/demo purposes. No reuse without permission.
