Restaurant Reservation and Online Ordering System
This project is a comprehensive solution for managing restaurant reservations and online orders in real-time, developed using ASP.NET Core 6.0 and SignalR technologies. It allows users to place orders and make reservations seamlessly, while the admin panel handles real-time management of these operations with live updates.

🚀 Project Overview
The primary goal of this project is to streamline restaurant operations by enabling users to place orders and create reservations online. Admins can manage these requests through a real-time dashboard, providing instant updates on reservations, orders, and other key activities.

🔑 Features
Online Ordering: Users can browse the menu and add items to their cart after logging in, then proceed with the order.
Reservations: Customers can easily reserve a table, and admins can view and manage these reservations in real-time.
Real-Time Admin Panel: Admins can approve or reject orders and reservations instantly, with real-time notifications sent to customers and admins using SignalR.
Email Notifications: Automatic email notifications are sent upon status changes to both customers and admins.
Secure Login: User authentication and security are managed using ASP.NET Identity.
🛠️ Technical Details
ASP.NET Core 6.0
SignalR for real-time data updates
Entity Framework Code First for database management
MSSQL as the relational database
MailKit for email notifications
AutoMapper for object-to-object mapping
Ajax, HTML, CSS, JavaScript, Bootstrap for a responsive frontend
📁 Project Structure
The project is built using an N-Tier Architecture for maintainability and scalability:

UI Layer: Manages the frontend components
Entity Layer: Defines the data entities
DataAccess Layer: Handles database access and operations
Business Layer: Contains the business logic
Dto Layer: Manages data transfer objects for secure data handling
Web API Layer: Facilitates backend communication through RESTful services
📋 Key Features for Admins
CRUD Operations: Full control over products, categories, and site data
Real-Time Reservations: View and manage reservations without refreshing the page
Live Notifications: SignalR-powered updates on order and reservation status
Discount Management: Apply and manage discounts on products
Real-Time Statistics: View live statistics of orders, tables, and revenue
✨ Highlights
Real-Time Messaging: A chat-like interface for live updates between users and admins
Table Status Monitoring: Real-time updates on table availability and reservation status
Email Notifications: Automatic emails sent to admins and customers for order or reservation updates
Discount Feature: Easily apply discounts to menu items
Secure Authentication: Powered by ASP.NET Identity for robust security features
🧩 Technologies Used
Backend: ASP.NET Core 6.0, ASP.NET Core Web API, SignalR, Entity Framework, MSSQL
Frontend: HTML, CSS, JavaScript, Bootstrap, Ajax
Utilities: AutoMapper, PagedList, MailKit
Architecture: N-Tier Architecture, DTO pattern
