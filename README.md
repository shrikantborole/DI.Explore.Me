## Dependency Injection (DI)

Dependency Injection is a design pattern commonly used in software development, especially in object-oriented programming. It involves passing dependencies (objects or services) into a component or class rather than having the component or class create its dependencies internally. This promotes loose coupling between components, making the codebase more modular, testable, and maintainable. DI helps improve code readability, facilitates unit testing, and enables easier management of dependencies.

## Lifetime Scope

Lifetime scope, also known as object lifetime management, refers to how long an object or service persists within an application. Different dependency injection frameworks provide various options for managing the lifetime scope of objects. Common lifetime scopes include:

- **Transient**: Objects are created each time they are requested. This scope is suitable for stateless and lightweight objects.
- **Singleton**: Objects are created once and shared across the entire application. This scope is suitable for objects that need to maintain state throughout the application's lifetime.
- **Scoped**: Objects are created once per request or per logical scope. This scope is suitable for objects that need to maintain state within a specific context, such as an HTTP request.

Managing the lifetime scope of objects is essential for optimizing memory usage and ensuring proper behavior within an application.

## Microsoft Default Framework for DI

In the context of .NET and ASP.NET development, Microsoft's default framework for Dependency Injection is provided by the `Microsoft.Extensions.DependencyInjection` namespace. This framework is commonly used in ASP.NET Core applications for managing dependencies and performing dependency injection.

Key features of Microsoft's default DI framework include:

- **Registration of Services**: The framework allows developers to register services and their corresponding implementations within the application's service collection.
- **Constructor Injection**: Dependencies are injected into the constructor of classes or components, promoting the use of constructor injection as a preferred method.
- **Built-in Container**: The framework includes a built-in service container that resolves dependencies and manages their lifetime scopes based on the configured registration.
- **Support for Transient, Singleton, and Scoped Lifetimes**: Developers can specify the lifetime scope of registered services, choosing between transient, singleton, and scoped lifetimes based on the application's requirements.
- **Integration with ASP.NET Core**: The DI framework seamlessly integrates with ASP.NET Core applications, allowing for easy dependency injection into controllers, middleware, and other components.

Here you will get examples for DI using different scopes, demonstrating how to register and resolve dependencies with transient, singleton, and scoped lifetimes.
