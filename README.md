# simple-dumpfile-analysis demo project
Simple dump file analysis demonstration

Pre-requisites: Visual Studio 2019 (You can port the controller code to run on older versions)

1. Clone the repository.
2. Open limeandcode-dumpfile-analysis.sln file.
3. Change Build version to 'Release'.
4. Click on limeandcode-dumpfile-analysis project and Debug-run it using IIS Express.
5. You will see a browser open automatically and see the .NET Core MVC template web application.
6. Append the following to your url in your browser: Home/buggyaction (e.g. localhost:44301/home/buggyaction)
7. You will see the page loading without completion.
8. Open your Task Manager, and right-click on a process called "iisexpress.exe" and create a dump file.
9. Open the dump file using Visual Studio, and click "Debug with Managed Only".

