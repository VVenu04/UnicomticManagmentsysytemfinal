# Unicomtic Managment sysytem 

## Overview
This project requires some initial setup to restore necessary packages and rebuild the project. Follow the steps below to set up the environment and run the app.

## Steps to Run the Project

### Step 1: Restore NuGet Packages
1. Open the solution file (`.sln`) in Visual Studio.
2. Go to the **Tools** menu → **NuGet Package Manager** → **Package Manager Console**.
3. In the console, run the following command to reinstall all NuGet packages:

~~~
	Update-Package -reinstall
~~~



### Step 2: Clean & Rebuild the Project in Visual Studio
1. In the top menu, go to **Build** → **Clean Solution** to clean the project.
2. After cleaning, go to **Build** → **Rebuild Solution** to rebuild the project.

### Step 3: Run the Application
1. Press **F5** to run the application.

## Requirements
- Visual Studio (latest version recommended)
- .NET Framework/Core (version as per the project requirements)
- NuGet for package management

## Additional Notes
- Ensure that your system is configured with the necessary dependencies for the project to run correctly.
- If you encounter any issues with package installation or build, make sure you have an active internet connection and the latest updates for Visual Studio.

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
