# T5.PR1.MiquelManzano
## Database project SetUp

To import the database, you will need [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads). After downloading it, you must set your connection string in the project's *appsettings.json*. Then, you need to update the database using migrations in PowerShell. Here are the commands to do it:

>**Update Database:** dotnet ef database update LastMigrationName

>**Add a new Migration:** dotnet ef migrations add NewMigrationName


## Project Documentation
[Click here.](https://docs.google.com/document/d/1cOVEnhTvQ4ThfBVHKkrxqg90_rhs7JmBA5wmq4wyM7E/edit?usp=sharing)