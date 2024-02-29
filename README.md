# WatchWorld

A sample N-layered .NET Core Project Demonstrating Clean Architecture and the Generic Repository Pattern.

## Packages

### Application Core
- Ardalis.Specification

### Infrastructure
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- npgsql.EntityFrameworkCore.PostgreSQL

### Web
...

### UnitTests
...

## Migrations

Before running the following commands, ensure that "Web" is set as the startup project. Run the following commands in the "Infrastructure" project.

### Infrastructure
```
Add-Migration InitialCreate -Context WatchWorldContext -OutputDir Data/Migrations
Update-Database -Context WatchWorldContext
```
