# DatingApp

# A demo application of MVC ASP.NET  3.1 technology
# Front-End Angular 8
# SQLlite database 

# Create a datingapp.db database in the project folder, if you wish to use database

backend development -->DatingApp.API
frontend development angular -->DatingApp-SPA

frontend start ng serve
backend dotnet watch run

Create and update your database
--> dotnet ef database update

Frontend http://localhost:4200
debugging postman POST --> http://localhost:5000/api/auth/register

For example.
{
	"username": "jack",
	"password": "yourpassword"
}

after that
http://localhost:5000/api/auth/login

please note authentication middleware is working



