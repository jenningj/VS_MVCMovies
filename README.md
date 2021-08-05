# VS_MVCMovies
Repo for the Visual Studio MVC Movies Web Application

Follows the tutorials 
1. https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-5.0&tabs=visual-studio
2. https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0
3. https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud?view=aspnetcore-5.0


Note in Part 1 when adding the scaffolging for hte Movies class came across a SQL Server based error, on googling the error the solution was this:

https://docs.microsoft.com/en-us/answers/questions/265773/getting-error-while-scaffolding.html

Uninstall-Package Microsoft.EntityFrameworkCore.Tools and Reinstall the package.

PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer
PM> Install-Package Microsoft.EntityFrameworkCore.Tools

PM> Add-Migration InitialMigration

