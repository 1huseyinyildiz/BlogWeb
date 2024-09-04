# Blog Application

This project is a full-stack blog application built with .NET Core on the backend and Angular standalone components on the frontend. The solution is designed for scalability, modularity, and clean architecture. It also includes support for CI/CD with Jenkins and RabbitMQ for messaging.

## Technologies Used

- **.NET Core**: The backend framework used for API development.
- **Angular Standalone**: Modern frontend framework for building dynamic single-page applications (SPA).
- **FluentValidation**: For validating models in a clean and maintainable way.
- **Autofac**: Dependency injection container for better management of dependencies.
- **Jenkins (AutoDeploy)**: Continuous Integration and Continuous Deployment (CI/CD) pipeline to automatically deploy the application.
- **RabbitMQ**: Message broker used for handling asynchronous communication.
  
## Solution Structure

The solution consists of several projects organized by responsibility, following SOLID principles and clean architecture.

### **Business**
Contains the core business logic of the application, including:
- `Aspects`: Handles cross-cutting concerns such as logging and caching.
- `Authentication`: Manages user authentication and authorization.
- `Concrete`: Contains the implementation of business rules.
- `Utilities`: Includes helper functions and utilities.
- `ValidationRules`: Business rules validation using FluentValidation.

### **Core**
The core library providing base functionalities shared across different layers.
- `CrossCuttingConcerns`: Includes global caching and validation mechanisms.
- `DataAccess`: Abstracts the data access layer, supporting Entity Framework and MongoDB.
- `DependencyResolvers`: Manages dependency injection configurations.

### **Data**
Responsible for managing entities and data transfer objects (DTOs).
- `Entities`: Defines the data models used throughout the application.
- `Repositories`: Abstract repository pattern implementation for data access.

### **Extensions**
Utility functions and middleware components that extend the functionality of the application.
- `ExceptionMiddleware`: Handles global exception handling.
- `ServiceCollectionExtensions`: Helper methods for setting up dependency injection.

### **Utilities**
Includes utility classes for common operations.
- `Hashing`: Contains functions for hashing and encrypting sensitive data.
  
## Getting Started

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/blog-app.git
    ```
