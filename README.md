# Restaurant Reservation and Online Ordering System

This project offers a robust solution for managing restaurant reservations and online orders in real-time. Developed with **ASP.NET Core 6.0** and **SignalR**, it enables users to place orders and create reservations seamlessly, while providing admins with real-time management capabilities.

## 🚀 Project Overview

This application aims to enhance restaurant operations by allowing users to place orders and make reservations online. Admins can manage these requests through a real-time dashboard, receiving instant updates on reservations, orders, and other key activities.

## 🔑 Features

- **Online Ordering:** Users can log in, browse the menu, add items to their cart, and place orders.
- **Reservations:** Customers can reserve tables, and admins can view and manage these reservations in real-time.
- **Real-Time Admin Panel:** Admins can instantly approve or reject orders and reservations with real-time notifications powered by SignalR.
- **Email Notifications:** Automated emails are sent to notify customers and admins about status changes.
- **Secure Login:** User authentication and security are managed using **ASP.NET Identity**.
- **QR Code Generation:** Admins can generate QR codes for tables and orders within the admin panel.

## 🛠️ Technical Details

- **ASP.NET Core 6.0**
- **SignalR** for real-time updates
- **Entity Framework Code First** for database management
- **MSSQL** for the relational database
- **MailKit** for email notifications
- **AutoMapper** for object-to-object mapping
- **Ajax, HTML, CSS, JavaScript, Bootstrap** for a responsive frontend

## 📁 Project Structure

The project employs an **N-Tier Architecture** to ensure maintainability and scalability:

- **UI Layer:** Handles the frontend components
- **Entity Layer:** Defines data entities
- **DataAccess Layer:** Manages database access and operations
- **Business Layer:** Contains the business logic
- **Dto Layer:** Manages data transfer objects for secure data handling
- **Web API Layer:** Facilitates backend communication through RESTful services

## 📋 Admin Features

- **CRUD Operations:** Manage products, categories, and site data
- **Real-Time Reservations:** View and manage reservations without page refreshes
- **Live Notifications:** Receive real-time updates on orders and reservations
- **Discount Management:** Apply and manage discounts on products
- **Real-Time Statistics:** Monitor live statistics for orders, tables, and revenue
- **QR Code Generation:** Generate QR codes for tables and orders through the admin panel

## ✨ Highlights

- **Real-Time Messaging:** Chat-like interface for live updates between users and admins
- **Table Status Monitoring:** Real-time updates on table availability and reservation status
- **Email Notifications:** Automatic emails for updates on orders and reservations
- **Discount Feature:** Easily apply discounts to menu items
- **Secure Authentication:** Robust security features powered by ASP.NET Identity
- **Admin QR Code Generation:** QR codes can be created by admins for table reservations and orders

## 🧩 Technologies Used

- **Backend:** ASP.NET Core 6.0, ASP.NET Core Web API, SignalR, Entity Framework, MSSQL
- **Frontend:** HTML, CSS, JavaScript, Bootstrap, Ajax
- **Utilities:** AutoMapper, MailKit
- **Architecture:** N-Tier Architecture, DTO Pattern

