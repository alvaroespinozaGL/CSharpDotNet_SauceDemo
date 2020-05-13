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

# Jenkins CI
## Configure Git on Jenkins configure tools

make sure you have configured Git on jenkinsURlconfigure tools
Path to Git executable:/usr/bin/git


## C-Sharp Dotnet Core Jenkins Project

1- First create new item on Jenkins Main dashboard, then choose a name for your project and select Freestyle project and click ok


2- In the General tab select Github Project and point to your repository .git


3- go to tab Source Code Management and configure your Git repository and if it is private add the credentials 


4-the last step will be choose the add build step as Execute Shell and in the script we will include de dependencies to run donet core and run the test from Jenkins:

```bash
#!/bin/bash
INSTALLDIR="cli-tools"
CLI_VERSION=1.0.1
DOWNLOADER=$(which curl)
if [ -d "$INSTALLDIR" ]
then
    rm -rf "$INSTALLDIR"
fi
mkdir -p "$INSTALLDIR"
echo Downloading the CLI installer.
$DOWNLOADER https://dot.net/v1/dotnet-install.sh > "$INSTALLDIR/dotnet-install.sh"
chmod +x "$INSTALLDIR/dotnet-install.sh"
echo Installing the CLI requested version $CLI_VERSION. Please wait, installation may take a few minutes.
"$INSTALLDIR/dotnet-install.sh" --install-dir "$INSTALLDIR" --version $CLI_VERSION
if [ $? -ne 0 ]
then
    echo Download of $CLI_VERSION version of the CLI failed. Exiting now.
    exit 0
fi
echo The CLI has been installed.
LOCALDOTNET="$INSTALLDIR/dotnet"
# Run the build process now. Implement your build script here.
export PATH=/usr/local/share/dotnet:$PATH
dotnet build
dotnet test
```

## References
https://github.com/dotnet/sdk/issues/6947

https://docs.microsoft.com/en-us/dotnet/core/tools/using-ci-with-cli

https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test

