# coreboilerplate

Note that this project is still in the design & development phase. `Expected Beta Release by June 20, 2021.`

## What is coreboilerplate?

`coreboilerplate` is an ASP.NET Core 5.0 Boilerplate Template that helps you create complete web applications by following best code practices and various Clean Architecture principles.

## Dedicated Documentation

With this project, I decided to have a seperate website just for maintaing project related documents that should help everyone understand the project in and out. It will include detailed architectural concepts, tutorials for adding more features / infrastructure and so on. 

Note the documentations will be ready once the codebase is available for production. You can view [coreboilerplate Documentation here!](https://coreboilerplate.net)

## Technology Stack

Solution follows Hexagonal / Onion Architecture to keep the entire application clean and scalable.

## Deployment

- Docker Container

### Base API - Infrastructure

- Swagger
- API Versioning
- Chat via SignalR Hubs
- Complete User Management - Microsoft Identity
- JWT Authentication with Refresh Tokens
- Audit Trails
- Automapper
- Global Exception Handling Middleware
- Uniform API Response
- Dynamic Service Registrations
- Serilog Implementation


### Infrastructure

- Entity Framework Core - MSSQL, MySQL etc.
- Mail Service - SMTP / SendGrid
- DB Seeding
- Dapper
- Hangfire

### Blazor - UI

- Mudblazor - Fluid UI Material Component Library
- HttpInterceptor
- Blazored Local Storage
- Realtime Chat
- Localization

### MVC - UI

- AdminLTE Integration
- Polly
- Realtime Chat
- Localization

## Github Branches

So, the idea is to keep the bare minimum in the `main` branch and to keep sample implementation in seperate branches. This way, you don't have to deal with unwanted boilerplate codes while creating new projects using this template.

## Support :star:

Has this Project helped you learn something New? or Helped you at work? Do Consider Supporting. 
Here are a few ways by which you can support.

-   Leave a star! :star:
-   Recommend this awesome project to your colleagues. 🥇

### Project Maintained by Mukesh Murugan

-   Blogs at [codewithmukesh.com](https://www.codewithmukesh.com)
-   Facebook - [codewithmukesh](https://www.facebook.com/codewithmukesh)
-   Twitter - [Mukesh Murugan](https://www.twitter.com/iammukeshm)
-   Twitter - [codewithmukesh](https://www.twitter.com/codewithmukesh)
-   Linkedin - [Mukesh Murugan](https://www.linkedin.com/in/iammukeshm/)

## License

Distributed under the MIT License.
