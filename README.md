Kasey Sanderson - Week 2
ksanderson_week2 Read Me Notes:

This assignment is meant to demonstrate the use of
dependency injection (DI) and separation of concerns
in ASP.Net Core

-Domain logic is defined in dedicated service (ICalculator and Calculator)
-Service is registered in the DI container w/ a Singleton lifetime since it is stateless
-Controller (MathController) depends only on the abstraction 
-The separation allows for easier testing and greater
flexibility later on
-Unit tests validate domain logic independently from web layer

Running the Project Using Visual Studio
1. Open ksanderson_week2.sln in Visual Studio.
2. In Solution Explorer, right-click the solution and select **Set Startup Projects...**.
   - Set `ksanderson_week2` as the Startup Project.
3. Select the desired run profile (IIS Express or ksanderson_week2).
4. Press F5 (Debug) or Ctrl+F5 (Run without debugging).
5. Swagger UI should open automatically in your browser

