# ASP.NET Core Learning Repository

This repository documents the progressive learning stages of ASP.NET Core development, transitioning from fundamental concepts to advanced architectural patterns. The project is divided into seven distinct stages, each focusing on specific aspects of the framework.

## Project Structure and Learning Stages

### Stage One: Fundamentals
*   **Focus**: Introduction to the ASP.NET Core environment.
*   **Key Components**: Basic project structure setup, configuration of the application pipeline, and initial exploration of web development fundamentals in .NET.

### Stage Two: Introduction to MVC
*   **Focus**: Model-View-Controller (MVC) architecture.
*   **Key Components**: Implementation of basic Controllers, Models, and Views. Understanding the separation of concerns and routing fundamentals in ASP.NET Core.

### Stage Three: Client-Side Dependency Management
*   **Focus**: Managing static web assets.
*   **Key Components**: Integration of Library Manager (libman) to handle client-side libraries. Continued refinement of the MVC structure and integration of external frontend dependencies.

### Stage Four: Advanced MVC Concepts
*   **Focus**: Enhancing the MVC implementation.
*   **Key Components**: Deepening the understanding of data passing, view rendering, controller logic, and overall application flow within the MVC paradigm.

### Stage Five: Dependency Injection and Services
*   **Focus**: Service-oriented architecture and extensibility.
*   **Key Components**: Introduction of custom Services and Dependency Injection (DI) to promote loose coupling and testability. Implementation of custom Extension methods to streamline code operations.

### Stage Six: Areas and ViewModels
*   **Focus**: Organizing large-scale applications.
*   **Key Components**: Implementation of ASP.NET Core Areas to partition the application into smaller, manageable functional groupings. Introduction of ViewModels to encapsulate data tailored specifically for views, cleanly separating presentation logic from domain models.

### Stage Seven: Application Refinement
*   **Focus**: Consolidation of advanced patterns.
*   **Key Components**: Combining Areas, ViewModels, Services, and client-side management into a cohesive and structured application architecture, representing a mature and scalable ASP.NET Core project setup.

## Technical Stack
*   **Framework**: ASP.NET Core
*   **Language**: C#
*   **Architecture**: MVC, Areas, Service-Oriented (DI)
*   **Tooling**: Library Manager (LibMan)

## Getting Started
To run any of the stages, navigate to the specific stage directory and use the .NET CLI:
```bash
cd Stage[Number]
dotnet build
dotnet run
```
