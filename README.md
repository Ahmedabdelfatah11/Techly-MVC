#  Techly – E-Commerce Platform  

![.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-512BD4)  ![C#](https://img.shields.io/badge/C%23-239120)  ![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4)  ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927)  ![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3)  ![Docker](https://img.shields.io/badge/Docker-2496ED) ![Stripe](https://img.shields.io/badge/Stripe-635BFF)
  

Techly is a modern **E-Commerce platform** for mobiles, laptops, and their accessories. It provides customers with a smooth shopping experience and admins with powerful product and order management tools.  

---

## ✨ Features  

The **Techly Platform** provides:  

### 👥 User Management  
The platform supports multiple roles with different permissions:  

- **Admin** → Manage users, roles, and companies  
- **Employee** → Manage orders and assist in operations  
- **Company** → Add and manage their products  
- **Customer** → Browse products, add to cart, and checkout  

### 🛍️ Product Management  
- Browse mobiles, laptops, and accessories.  
- Search and filter products by **brand, price, and category**.  
- Detailed product pages with **images, specs, and price**.  
- **Admin** can add, edit, and delete products.  

### 🛒 Cart & Orders  
- Add products to cart.  
- Update item quantities.  
- Checkout process with shipping details.  
- Order history for customers.  
- **Admin** can manage and update order statuses.  

### 💳 Payments  
- Integrated with **Stripe** for secure online payments.  
- Future support for **Paymob, Fawry, etc.**.  

### 📦 Accessories Management  
- Separate category for accessories.  
- Bundled product offers (e.g., Laptop + Bag + Mouse).  

---

## 📗 Table of Contents  
- [📖 About the Project](#-about-the-project)  
- [🛠 Built With](#-built-with)  
  - [Tech Stack](#tech-stack)  
- [💻 Getting Started](#-getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Setup](#setup)  
  - [Install](#install)  
  - [Usage](#usage)  
  - [Docker](#-docker-setup) 
  - [Deployment](#deployment)  
- [🔭 Future Features](#-future-features)  
- [⭐️ Show your support](#️-show-your-support)  
- [🙏 Acknowledgements](#-acknowledgements)  
- [📝 License](#-license)  

---

## 📖 About the Project  

**Techly** is a modern **ASP.NET MVC E-Commerce platform** where users can:  
- Browse mobiles, laptops, and accessories.  
- Make secure purchases and manage orders.  
- Admins can manage inventory, products, and orders easily.  

Repository:  
- **Backend + Frontend (ASP.NET MVC)** → [Techly](https://github.com/Ahmedabdelfatah11/Techly)  

---

## 🛠 Built With  

### Tech Stack  
- **Backend & Frontend**: ASP.NET MVC, Entity Framework, **SQL Server**  
- **UI**: Razor Views, Bootstrap  
- **Authentication**: ASP.NET Identity  
- **Payments**: Stripe / Paymob (planned)  
- **Containerization**: Docker, Docker Compose  

---

## 💻 Getting Started  

### Prerequisites  
- .NET SDK  
- SQL Server (local or remote)  
- Docker & Docker Compose (for containerized setup)  

### Setup  
Clone the repository:  
```bash
git clone https://github.com/Ahmedabdelfatah11/Techly.git
```

### Install
Restore dependencies:
```
cd Techly
dotnet restore
```

## 🐳 Docker Setup

The project comes with a pre-configured **docker-compose.yml** file.  
It will run both the **Techly App** and a **SQL Server** instance inside containers.

### Run the app with Docker
```bash
docker-compose up --build
```

### Services

- SQL Server → localhost:8002

- User: sa

- Password: YourStrongP@ssw0rd123

- Techly App → http://localhost:8080
### Notes
The app runs with ASPNETCORE_ENVIRONMENT=Docker.

Update your connection string in appsettings.Docker.json if needed

## Deployment
- Can be deployed on Azure, IIS, or any VPS with SQL Server.

- Docker images can be pushed to Docker Hub or deployed on Azure Container Instances / AWS ECS.

## 🔭 Future Features
- Multi-language support 🌐

- Product reviews & ratings ⭐

- Wishlist functionality 💖

- Advanced admin dashboard with analytics 📊

## ⭐️ Show your support

If you like this project, please ⭐ it on GitHub!


### 🙏 Acknowledgements

- Inspired by leading E-Commerce platforms (Amazon, Jumia, Noon).
  
- Thanks to the open-source community ❤️

### 📝 License

This project is MIT licensed.
