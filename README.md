Application for maintaining contact information

Expected functionality:
- List contacts
- Add a contact
- Edit contact
- Delete/Inactivate a contact

Requirements:

- Visual Studio 2012 
- SQL Server 2012 Express LocalDB (to run locally)

Method 1

To run the sample locally from Visual Studio:
- Build the solution.
- Press F5 to debug.

Method 2

To run the sample locally from Visual Studio:

- Change connectionStrings in Web.Config and App.config
- Build the solution.
- Open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console)
- In the Package Manager Console window, enter the following command: Update-Database
- Press F5 to debug.
