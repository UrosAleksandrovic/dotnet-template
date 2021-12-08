# How to install
## Prerequisites
Only the dotnet CLI is needed in order to create a project from the template.

More info: https://docs.microsoft.com/en-us/dotnet/core/tools/
## Install
Navigate to the root folder and run the following command
 
```bash
dotnet new --install .\ # for Windows
# or
dotnet new --install ./ # for Linux/Mac
```

More info: https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template#create-the-template-config

# Create a new project
Once the template is installed simply navigate to the new project path and run
```bash
dotnet new prminternship -n ProjectName
```

Additional creation options can be found by running
```bash
dotnet new prminternship -h
```