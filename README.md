# DatingApp

# A demo application of MVC ASP.NET CORE 3.1 technology
# Front-End Angular 8
# SQLlite database 

Please create a SQLlite datingapp.db database in the back-end project folder, if you wish to use database

backend development -->DatingApp.API
frontend development angular -->DatingApp-SPA

frontend start ng serve
backend dotnet watch run

Create and update your database
--> instructions https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=visual-studio
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



