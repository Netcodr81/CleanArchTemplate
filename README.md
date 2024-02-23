# Clean Arch Template
A clean architecture template for use with .NET applications.

## Installation
To install the template locally follow the following steps:

1. Open a command line prompt in one of the template you would like to install. These include:
   - CleanArchTemplate.Api
   - CleanArchTemplate.BlazorServer
   - CleanArchTemplate.BlazorWASM
   - CleanArchTemplate.BlazorWebApp
   - CleanArchTemplate.MVC

2. Run the following command
```bash
dotnet new install .
```

The template should be installed now. You can verify this by running the following command:

```bash
dotnet new list
```

The template should be listed under one of the names seen in step 1.

## How to uninstall the template

1. Use the following command along with the template name

```bash
dotnet new uninstall `template name`
```

> [!Note]
> The templates are still in the process of being developed and may change.
