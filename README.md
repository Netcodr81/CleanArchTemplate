# Clean Arch Templates
A collection of clean architecture templates for use with .NET applications.

> [!Note] The templates included are for applications using .NET 8+

## Application templated included
- ASP.NET Core Web Api
- Blazor Server
- Blazor WASM
- Blazor Web App
- MVC


## Installation

```bash
dotnet new install CleanArch.Templates
```

The template should be listed under one of the names seen in step 1.

## How to uninstall the template

```bash
dotnet new uninstall CleanArch.Templates
```

## How to use the templates
---
Using Visual Studio:
   1. Search for Clean Arch in the templates search box.
   2. A list of the following templates should appear
      - CleanArchTemplate.Api 
      - CleanArchTemplate.BlazorServer
      - CleanArchTemplate.BlazorWASM
      - CleanArchTemplate.BlazorWebApp
      - CleanArchTemplate.MVC

   3. Select the desired template and follow the splash screens. It is suggested to select `Place solution and project in the same directory`. This prevents duplicate project folders.

Using the CLI:
   1. Choose a project template i.e. cleanarch-webapi, cleanarch-blazorserver, cleanarch-blazorwasm, cleanarch-blazorwebapp, cleanarch-mvc.
   2. Run `dotnet new 'projectname' --help` to get a list of features for each template.
   3. Run `dotnet new 'projectname` -n 'Name of Project' -o 'The output folder'.


## Upcoming additions

1. Additional/updated clean architecture user guides.
2. A default .editorconfig file.