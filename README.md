## Mystical Animal Shelter

### By Jake Edgar

A web application to for a mystical animal shelter.

## Tech Used

- C#
- DotNet
- Razor
- HTML
- CSS
- Entity Core
- Identity Authorization
- Swagger 
- MySQL
- Jwt Authentication

## Description

A web application that allows a user to log in and create treats with flavors, and vice versa.

## Setup/Installation Requirements

- First make sure you have MySql Workbench downloaded and properly installed. You will also need a text editor and a command line that you are comfortable with.

- In you command line navigate to your desktop directory and clone this project using _Git Clone https://github.com/jakeedgar/AnimalShelterApi.Solution.git_

- Open the project in your preferred text editor, I recommend VSCode.

- To access the database please do as follows:

  - First create a file using the _touch_ command in your command line, at the root of the project directory called "appsettings.json" and in that file add the following code, but substituting the text in the brackets for your own information.

  ```
  { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[your_database];uid=[Your ID];pwd=[Your Password];" } }
  ```

- In your command line navigate to the directory _"AnimalShelterApi.Solution"_ then cd into _"AnimalShelter"_ and run the following commands in order:

  - _dotnet restore_
  - _dotnet build_
  - _dotnet ef migrations add Initial_
  - _dotnet ef database update_
  - _dotnet run_

- Follow the prompt to view the project at _localhost:5000_ with your preferred browser. I recommend Google Chrome.

## API Endpoint Documentation 

  * You can explore the API endpoints in postman.

 * You can view all of the endpoints with swagger, by running *dotnet run* in your terminal and then navigate to *https://localhost:5001/swagger/index.html* with your browser. 

 * Endpoints

 * Request Structure

    ```
    Get /api/animals/
    Post /api/animals/
    Get /api/animals/{id}
    Put /api/animals/{id}
    Delete /api/animals/{id}
    ```

 * Example Query

```http://localhost:5000/api/animals?breed=dragon&color=green```

 * Response
 ```
    { 
      AnimalId = 2, 
      Name = "Nick", 
      Breed = "Dragon",
      Color = "Green", 
      Age = 108, 
      Price = 0
    }
 ```

## Swagger

  * Swagger is a UI that runs 

## JWT AUTHENTICATION 
  * Jwt is a token based authentication system used to verify users via URL. They are a compact and self-contained way for securely transmitting information between parties as a JSON object.
  * It is not currently functioning on this project. 

## Known Bugs

- Jwt Authentication is not implemented properly and does not function.
- The build will not complete due to the Jwt Auth issues.

## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Jake Edgar
