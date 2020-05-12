# CSharpDotNet_SauceDemo
test automation with .netCore, C#, XUnit and Jenkins

## step-by-step guide about setting up the workflow in using X-Unit, VS Code, Selenium Web Driver and C# to unit test your code and user interface.
## before running the test:

Download and Install VS Code from here:

https://code.visualstudio.com/ 

Download and Install Dot Net Core SDK from here:

https://dotnet.microsoft.com/download

install from VS Code store the plugin nuget packages

install from VS Code store the plugin C#

install from VS Code store the plugin .Net Core test explorer 

From nuget packages look for Selenium webdriver

Download and Install Chrome Driver from here and put it on the location_of_your_test/bin/debug/netcoreapp3.1/

https://chromedriver.chromium.org/downloads

In mac Os catalina Chrome driver give us a security error so we can avoid by using the next command where you have located your webdriver file:
```bash
xattr -d com.apple.quarantine chromedriver
```
## Check if C# is installed correctly with .NetCore:
```bash
Dotnet -version
```
## Create a nunit test suite
```bash
Dotnet new nunit
```
## Build the .Net project
```bash
Dotnet build
```
