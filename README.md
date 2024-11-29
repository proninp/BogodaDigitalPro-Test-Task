# [Bogoda Digital Pro](https://bogoda.pro/) Test Task for [C# Backend developer](https://career.habr.com/vacancies/1000143847) position

Implement a contact list on ASP.NET Core Web Api Classic.

Requirements:

* Implement the desired data model/models;
* It is necessary to implement all CRUD operations for the main entity;
* The data should be stored in any way, preferably in a database;
* The application should reflect an understanding of layered architecture: API Layer, Persistence Layer, Business/Logic Layer, Domain(Core) Layer - at least;
* Using DTO and mapping is not necessary, but it will be an advantage;
* The application must have instructions for deployment.

# Launch Instructions

To run a project using the Entity Framework Core, follow these steps:

1. Building a Docker image go to the directory where the Dockerfile file is located and run the command to create the image:

```bash
docker build -t bogoda_contactsbook .
```

2. Launching the Docker container after successfully building the image, launch the container using the following command:

```bash
docker run -d -p 5432:5432 --name bogoda_contactsbook bogoda_contactsbook
```

3. Applying migrations In the root of the project, run the command to apply migrations to the created database:

``` bash
dotnet ef database update
```

After completing all the steps, the database will be successfully created and updated, and test data will be added to it.