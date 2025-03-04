﻿<h1>
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="content/MudBlazor-GitHub-NoBg-Dark.png">
    <source media="(prefers-color-scheme: light)" srcset="content/MudBlazor-GitHub-NoBg.png">
    <img alt="MudBlazor" src="content/MudBlazor-GitHub-NoBg.png">
  </picture>
</h1>

# Material Design components for Blazor
![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/mudblazor/mudblazor/build-test-mudblazor.yml?branch=dev&logo=github&style=flat-square)
[![Codecov](https://img.shields.io/codecov/c/github/MudBlazor/MudBlazor)](https://app.codecov.io/github/MudBlazor/MudBlazor)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=MudBlazor_MudBlazor&metric=alert_status)](https://sonarcloud.io/summary/overall?id=MudBlazor_MudBlazor)
[![GitHub](https://img.shields.io/github/license/mudblazor/mudblazor?color=594ae2&logo=github&style=flat-square)](https://github.com/mudblazor/MudBlazor/blob/master/LICENSE)
[![GitHub Repo stars](https://img.shields.io/github/stars/mudblazor/mudblazor?color=594ae2&style=flat-square&logo=github)](https://github.com/mudblazor/MudBlazor/stargazers)
[![GitHub last commit](https://img.shields.io/github/last-commit/mudblazor/mudblazor?color=594ae2&style=flat-square&logo=github)](https://github.com/mudblazor/mudblazor)
[![Contributors](https://img.shields.io/github/contributors/mudblazor/mudblazor?color=594ae2&style=flat-square&logo=github)](https://github.com/mudblazor/mudblazor/graphs/contributors)
[![Discussions](https://img.shields.io/github/discussions/mudblazor/mudblazor?color=594ae2&logo=github&style=flat-square)](https://github.com/mudblazor/mudblazor/discussions)
[![Discord](https://img.shields.io/discord/786656789310865418?color=%237289da&label=Discord&logo=discord&logoColor=%237289da&style=flat-square)](https://discord.gg/mudblazor)
[![Twitter](https://img.shields.io/twitter/follow/MudBlazor?color=1DA1F2&label=Twitter&logo=Twitter&style=flat-square)](https://twitter.com/MudBlazor)
[![NuGet version](https://img.shields.io/nuget/v/MudBlazor?color=ff4081&label=nuget%20version&logo=nuget&style=flat-square)](https://www.nuget.org/packages/MudBlazor/)
[![NuGet downloads](https://img.shields.io/nuget/dt/MudBlazor?color=ff4081&label=nuget%20downloads&logo=nuget&style=flat-square)](https://www.nuget.org/packages/MudBlazor/)

MudBlazor is an ambitious Material Design component framework for Blazor with an emphasis on ease of use and clear structure. It is perfect for .NET developers who want to rapidly build web applications without having to struggle with CSS and Javascript. MudBlazor, being written entirely in C#, empowers you to adapt, fix or extend the framework. There are plenty of examples in the documentation, which makes understanding and learning MudBlazor very easy.

## Documentation & Demo
- [MudBlazor.com](https://mudblazor.com)
- [Try.MudBlazor.com](https://try.mudblazor.com/)

## Why is MudBlazor so successful?
- Clean and aesthetic graphic design based on Material Design.
- Clear and easy to understand structure.
- Good documentation with many examples and source snippets.
- All components are written entirely in C#, no JavaScript allowed (except where absolutely necessary).
- Users can make beautiful apps without needing CSS (but they can of course use CSS too).
- No dependencies on other component libraries, 100% control over components and features.
- Stability! We strive for a complete test coverage.
- Releases often so developers can get their PRs and fixes in a timely fashion.

## Prerequisites
| MudBlazor | .NET | Support |
| :--- | :---: | :---: |
| 1.x.x - 2.0.x | .NET 3.1 | Ended 03/2021 |
| 5.x.x | .NET 5 | Ended 01/2022 |
| 6.x.x | [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0), [.NET 7](https://dotnet.microsoft.com/download/dotnet/7.0), [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) | Ended 01/2025 |
| 7.x.x | [.NET 7](https://dotnet.microsoft.com/download/dotnet/7.0), [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) | Limited |
| 8.x.x | [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0), [.NET 9](https://dotnet.microsoft.com/download/dotnet/9.0) | :heavy_check_mark: |

> [!TIP]
> If you're updating to a newer version of MudBlazor, make sure to check out the [Migration Guide](https://github.com/MudBlazor/MudBlazor/blob/dev/MIGRATION.md) for detailed instructions on handling breaking changes and new features.  

> [!WARNING]
> 1. Static rendering is not supported - [Learn more](https://learn.microsoft.com/aspnet/core/blazor/components/render-modes).
> 2. We cannot guarantee compatibility with browsers no longer maintained by their publishers.
For the best experience, use an up-to-date browser - See [Blazor supported platforms](https://learn.microsoft.com/aspnet/core/blazor/supported-platforms).

## Stats
![Alt](https://repobeats.axiom.co/api/embed/db53a44092e88fc34a4c0f37db12773b6787ec7e.svg "Repobeats analytics image")

## Contributing
👋 Thanks for wanting to contribute!  
Contributions from the community are what makes MudBlazor successful.

If you are familiar with technologies like C#, Blazor, JavaScript, or CSS, and wish to give something back, please consider submitting a pull request!
We try to merge all non-breaking bugfixes and will deliberate the value of new features for the community.
Please note there is no guarantee your PR will be merged, so if you want to be sure before investing the work, feel free to [contact the team](https://discord.gg/mudblazor) first.

Check out the [contribution guidelines](/CONTRIBUTING.md) to understand our goals and learn more about the internals of the project.

## Getting Started
We have premade templates available at the [MudBlazor.Templates](https://github.com/mudblazor/Templates) repository.

Full installation instructions can be found [on our website](https://mudblazor.com/getting-started/installation).

### Quick Installation Guide
Install Package
```
dotnet add package MudBlazor
```
Add the following to `_Imports.razor`
```razor
@using MudBlazor
```
Add the following to the `MainLayout.razor` or `App.razor`
```razor
<MudThemeProvider/>
<MudPopoverProvider/>
<MudDialogProvider/>
<MudSnackbarProvider/>
```
Add the following to your HTML `head` section, it's either `index.html` or `_Layout.cshtml`/`_Host.cshtml`/`App.razor` depending on whether you're running WebAssembly or Server
```razor
<link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet" />
<link href="_content/MudBlazor/MudBlazor.min.css" rel="stylesheet" />
```
Next, add the following to the default Blazor script at the end of the `body`
```razor
<script src="_content/MudBlazor/MudBlazor.min.js"></script>
```

Add the following to the relevant sections of `Program.cs`
```c#
using MudBlazor.Services;
```
```c#
builder.Services.AddMudServices();
```

### Usage
```razor
<MudText Typo="Typo.h6">
    MudBlazor is @Text
</MudText>

<MudButton Variant="Variant.Filled" 
           Color="Color.Primary" 
           OnClick="ButtonOnClick">
    @ButtonText
</MudButton>

@code {
    string Text { get; set; } = "????";
    string ButtonText { get; set; } = "Click Me";
    int ClickCount { get; set; }

    void ButtonOnClick()
    {
        ClickCount += 1;
        Text = $"Awesome x {ClickCount}";
        ButtonText = "Click Me Again";
    }
}
```
