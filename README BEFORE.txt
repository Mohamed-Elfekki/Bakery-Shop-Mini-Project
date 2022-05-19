0- netcoreapp3.1

1- Open NuGet Package Manager and install (3.1.24 Version):
 Microsoft.EntityFrameworkCore,
 Microsoft.EntityFrameworkCore.SqlServer,
 Microsoft.EntityFrameworkCore.Tools

2- Open MSql server and create database name: BakeryShop

3- Open data folder, BakeryShopContext.cs, Line14, change local server name to yours

4- Page Folder, Order.cshtml, Order.cshtml.cs, Change ****** in Lines 45,47, 59 To Real Data! 

5- Open pakage Manager Console and add these commands:

add-migration createDatabase -OutputDir "Data/Migrations"
update-database

6- Done, Its Work!!


