# Vehicle Validator Web App

VehicleValidator is a small ASP.NET Core MVC CRUD web application with a feature that checks if a vehicle is allowed to enter specific city zones based on its environmental category (EcoGroup).


The project demonstrates clean architecture principles, separation of concerns, and basic web development with ASP.NET Core.

 Features:

 User inputs vehicle EcoGroup
 System evaluates access permissions
  Displays whether the vehicle can enter:
  - Small ring
  - Big ring
  - Both
  - Neither

The validation logic is implemented in a dedicated service layer.


  Technologies Used:

- .NET (ASP.NET Core MVC)
- Razor Views
- Dependency Injection
- Service Layer Architecture


 Architecture Overview

The project follows a simple layered structure:

- Model - "Vehicle" - represents the input data.
- Service Layer - "VehicleValidator" contains business logic.
- Controller – "ValidatorController" handles requests and responses.
- View - Razor view for user interaction.
- Used dependecy injection that contains basic abstract baseclass "VehiclesValidator" with abstract method and class a "VehicleValidator" that inheritance the "VehiclesValidator" and
 override the method.
   
   
   How to start the app:
	1.Clone the repository.
	2.Open the project in Visual Studio.
	3.press ctrl + f5 and the app will start.
	
	In the future I can add a class in the Model that inheritance "Vehicle" class that inplements vehicles with special regime of movement such as(police cars, ambulances).
   
   My choise to not use enums and interfaces is because I want to focus more on ASP.NET Core technology and use ways of making logic with my current knowledge.
