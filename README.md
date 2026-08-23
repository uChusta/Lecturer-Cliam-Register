# Lecturer Cliam Register

# Lecturer Claim Register

A lightweight ASP.NET Core MVC application designed to manage, submit, and display draft lecturer claims via an in-memory repository, with integrated REST API support.

## Model-View-Controller Architectural Roles

* **Model (`ClaimDraft.cs`)**: Defines the core data structure representing a claim (Lecturer Name, Hours Worked, Hourly Rate, and calculated Total Amount). It acts as the business domain logic independent of UI formatting or HTTP routing.
* **View (`Index.cshtml`)**: Renders the HTML user interface using Razor syntax. It displays existing claims in a structured table and provides an input form for entering new claim data.
* **Controller (`ClaimsController.cs`)**: Coordinates application execution. It handles incoming HTTP GET/POST requests, delegates data modifications to the service, binds form input back to the model, and selects the appropriate View or JSON response to return.

## Useful ASP.NET Core Features Used

1. **Dependency Injection (DI)**: Built directly into the ASP.NET Core framework, DI allows `ClaimService` to be registered in `Program.cs` as a Singleton service and seamlessly injected into the `ClaimsController` constructor. This promotes loose coupling, testability, and centralized state management.
2. **Unified MVC and Web API Controllers**: ASP.NET Core combines Web API and traditional MVC architecture into a single pipeline. The same controller can return standard Razor rendering (`IActionResult` returning `View()`) alongside RESTful API responses (`IActionResult` returning `Ok(data)`), avoiding duplicate server infrastructure.