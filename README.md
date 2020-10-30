# _State and Nation Parks API_

#### _Week 6 C# API Project for Epicodus, October 30th, 2020_

#### By _**Mike Manchee**_

## Description

This Project is a State and National Parks API. The Project has full CRUD functionality as well as Token Authentication (database security), and Swagger (API documentation). The API with also be searchable and have a random parks feature.

<!-- 
Park Model
Parks Controller
Search
Random
Authentication
Swagger
*** Further Exploration 
Pagination
SeedDB
 -->
### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
|  1. Create Park Models  | ... | ... |
|  2. Admin Creates new park entry  | New Park | Add Row |
|  3. Admin Edits park Entry  | Edit Park | Edit Row |
|  4. Admin Deletes park entry  | Delete Park | Remove Row |
|  5. User Views Details  | View Details | GET Row |
|  6. User Views All Parks  | View All Parks | GET All Rows |
|  7. User Views Search of Parks  | Search Parks | GET Matching Rows |
|  8. User Views Random Park  | Random Park | Random Row |

## Setup/Installation Requirements

### Project from GitHub
* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with US Parks API<!-- TITLE HERE -->

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with US Parks API<!-- TITLE HERE -->

### Database Setup
* Go to appsettings.json and change the password if needed.

* Setup with SQL migrations
  * In the terminal, navigate to the project folder
  * Type "dotnet ef migrations add Initial" and wait for migration file to be built
  * Type "dotnet ef database update" and wait for build confirmation

### API Second Application
* this dotnet run works with http://localhost:6000; http://localhost:6001
### Swagger
* Type "dotnet watch run"
* Paste URL in browser "http://localhost:6000/swagger/index.html"
* Explore API

## Known Bugs

No Known Bugs

## Technologies Used
Project Specifics
* C# API

Main Programs
* MySQL
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet)
  * [Entity](https://docs.microsoft.com/en-us/ef/core/)
  * [Razor](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1)
  * [MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* CSS
  * [Bootstrap](https://getbootstrap.com/docs/4.5/getting-started/introduction/)
  * [Font Awesome](https://www.w3schools.com/icons/fontawesome_icons_intro.asp)
  * [Postman](https://www.postman.com/)


### Other Links
![GitHub](img/Github.png)
[Mike's GitHub](https://github.com/mmanchee)<br />
[LinkedIn](https://www.linkedin.com/in/mikemanchee/)<br />

### License

Copyright (c) 2020 **_{Mike Manchee}_**
Licensed under MIT