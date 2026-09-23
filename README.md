![MinimalHtmx banner](.github/banner.png)

# MinimalHtmx Template 📦🚀

<!-- portfolio-badges:start -->
<!-- Identity -->
[![phmatray - MinimalHtmx](https://img.shields.io/static/v1?label=phmatray&message=MinimalHtmx&color=blue&logo=github)](https://github.com/phmatray/MinimalHtmx)
![Top language](https://img.shields.io/github/languages/top/phmatray/MinimalHtmx)
[![Stars](https://img.shields.io/github/stars/phmatray/MinimalHtmx?style=social)](https://github.com/phmatray/MinimalHtmx/stargazers)
[![Forks](https://img.shields.io/github/forks/phmatray/MinimalHtmx?style=social)](https://github.com/phmatray/MinimalHtmx/network/members)
[![License](https://img.shields.io/github/license/phmatray/MinimalHtmx)](https://github.com/phmatray/MinimalHtmx/blob/HEAD/LICENSE)

<!-- Activity -->
[![Issues](https://img.shields.io/github/issues/phmatray/MinimalHtmx)](https://github.com/phmatray/MinimalHtmx/issues)
[![Pull requests](https://img.shields.io/github/issues-pr/phmatray/MinimalHtmx)](https://github.com/phmatray/MinimalHtmx/pulls)
[![Last commit](https://img.shields.io/github/last-commit/phmatray/MinimalHtmx)](https://github.com/phmatray/MinimalHtmx/commits)
<!-- portfolio-badges:end -->


A minimal .NET template for creating HTMX-based Blazor projects, leveraging Carter for routing and component-based architectures. This template provides a foundation for building interactive, server-driven web applications with Blazor and HTMX.

## Table of Contents 📋

<!-- TOC -->
* [MinimalHtmx Template 📦🚀](#minimalhtmx-template-)
  * [Table of Contents 📋](#table-of-contents-)
  * [Overview 🌐](#overview-)
  * [Features ✨](#features-)
  * [Installation ⚙️](#installation-)
  * [Usage 📑](#usage-)
    * [Running the Project ▶️](#running-the-project-)
  * [Project Structure 🏗️](#project-structure-)
  * [Customization ✏️](#customization-)
    * [Adding New Routes ➕](#adding-new-routes-)
    * [Modifying Components 🛠️](#modifying-components-)
    * [Using AppState 💾](#using-appstate-)
  * [Contributing 🤝](#contributing-)
  * [License 📜](#license-)
  * [About ℹ️](#about-ℹ)
* [Quick Start Guide 🚀](#quick-start-guide-)
<!-- TOC -->

## Overview 🌐

This template includes:

- 2 Blazor components (`PageCounter` and `PageContact`) with HTMX integration for building dynamic, server-side pages.
- Carter-based routing to handle minimal APIs seamlessly.
- Pre-configured HTMX components (`HxCounter`, `HxContact` and `HxContactEdit`) to handle server-side rendering and interactivity.
- A clean, minimal structure that supports server-side HTML updates without JavaScript.

## Features ✨

- **HTMX Integration**: Use HTMX to enable dynamic HTML updates without JavaScript, leveraging server-side interactions.
- **Carter Routing**: Minimal API routing using Carter makes defining API routes simple and clean.
- **Blazor Components**: Blazor components are used to encapsulate the UI, supporting easy reuse and testing.
- **.NET 8 Support**: Built to target .NET 8.0, ensuring compatibility with the latest features and enhancements.
- **Form Handling**: Use `hx-put` and `hx-get` to enable form binding and server-side state management.

## Installation ⚙️

Install the template using the `dotnet new` command:

```bash
dotnet new install Atypical.MinimalHtmx.Templates
```

## Usage 📑

Create a new project using the template:

```bash
dotnet new minimalhtmx -n YourProjectName
```

This command creates a new directory named `YourProjectName` with the template contents.

### Running the Project ▶️

Once the project is created, navigate to the directory and run the application:

```bash
cd YourProjectName
dotnet run
```

The project will be available at `https://localhost:{PORT}` by default.

## Project Structure 🏗️

- `Pages/Counter/PageCounter.razor`: Main Blazor component to display a counter.
- `Pages/Counter/PageCounter.razor.cs`: Defines API endpoints using Carter to handle GET and POST requests for counter data.
- `Pages/Counter/HxCounter.razor`: HTMX-enabled component that displays a counter.
- `Pages/Contact/PageContact.razor`: Main Blazor component to display a contact.
- `Pages/Contact/PageContact.razor.cs`: Defines API endpoints using Carter to handle GET and PUT requests for contact data.
- `Pages/Contact/HxContact.razor`: HTMX-enabled component that displays a contact's details.
- `Pages/Contact/HxContactEdit.razor`: HTMX-enabled edit form for contacts.
- `Store/AppState.cs`: Stores the state of the application, including contact details.

## Customization ✏️

### Adding New Routes ➕

To add new routes, modify the `AddRoutes` method in `PageContact.cs`. You can define new GET, POST, PUT, or DELETE endpoints using Carter's fluent routing API.

```csharp
public void AddRoutes(IEndpointRouteBuilder app)
{
    var group = app.MapGroup("htmx/contact");
    group.MapGet("/{Id:int}", HandleGet);
    group.MapPut("/{Id:int}", HandlePut);
    group.MapPost("/new", HandleCreateNew);
}
```

### Modifying Components 🛠️

Components are located by feature in the `Pages` folder. You can edit `HxContact.razor` and `HxContactEdit.razor` to change the UI and behavior of the contact display and edit functionality.

### Using AppState 💾

`AppState.cs` is used to store the state of your application, such as contact details. You can extend `AppState` to hold more data as your application grows.

<!-- portfolio-techstack:start -->

## Tech Stack

- **.NET 8**
- Microsoft.TemplateEngine.Tasks
- Carter

<!-- portfolio-techstack:end -->

## Roadmap 🗺️

- [ ] Add more starter pages/components beyond Counter and Contact (e.g. a paginated list)
- [ ] Upgrade template to .NET 9/10 once Carter and HTMX tooling catch up
- [ ] Provide an optional authentication-enabled variant of the template
- [ ] Add automated template tests (`dotnet new` + build verification) to CI
- [ ] Publish a short guided tutorial/sample gallery for common HTMX + Carter patterns

See the [open issues](https://github.com/phmatray/MinimalHtmx/issues) for details and to suggest new ideas.

## Contributing 🤝

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request to the repository.

## License 📜

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## About ℹ️

Developed by Philippe Matray, this template is aimed at developers looking for a minimal yet effective way to combine Blazor with HTMX and Carter, enabling interactive, server-driven web applications without relying on complex JavaScript frameworks.

---

# Quick Start Guide 🚀

1. **Install the Template**

   ```bash
   dotnet new install Atypical.MinimalHtmx.Templates
   ```

2. **Create a New Solution**

   ```bash
   mkdir HtmxDemo
   cd HtmxDemo
   dotnet new sln -n MyHtmxSolution
   ```

3. **Create a New MinimalHtmx Project**

   ```bash
   dotnet new minimalhtmx -n MyHtmxApp
   dotnet sln add MyHtmxApp
   ```

4. **Run the Application** ▶️

   Navigate to the project folder and run it:

   ```bash
   cd MyHtmxApp
   dotnet run
   ```

   You should see the application running at `https://localhost:{PORT}`.

