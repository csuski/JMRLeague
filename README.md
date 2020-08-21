# JMRLeague
This is an exampl project for NM .Net User group.

This project is an example of setting up a Blazor Server app and Blazor WASM app for a Marble Fantasy League.

The most insteresting items in this project is that it can be setup to have the Blazor Server and Blazor WASM running on a hosted location (Azure) using the same code and same Web API.


# WASM + Server in same project

Follow instructions from [Blazor Train](https://www.youtube.com/watch?v=SkYQDPXw__c&feature=youtu.be)
  * Create new Blazor Server Project
  * Add ASP host Blazor Wasm Project
  * Project reference Blazor Server to WASM Client & Shared
  * Blazor Server \_Hosts.cshtml change to client app component, turn off prerender (ServerMode="Server")
  * Setup multiple startup projects (Blazor Server & WASM Server)
  * Inject HTTP Client into Blazor Server (Startup.cs > ConfigureServices)
  * Point Blazors Server to Blazor WASM Server API (full path in FetchData)

This works for local host, but if you hard code the API into the service you can't deploy it anywhere else

* See JMRLeague.Shared\Services\ConfigurableService for an example improvement
* The configurable service is an abstract class that gets the location of the WASM Server hosing the API from the app settings
* This allows the WASM client to continue to use a relative location and work without changes no matter where it is hosted
* For Blazor Server AppSettings is configured in ConfigureServices and the property can be setup in Azure (or wherever it is deployed) to point to the WASM Server.
* Now there is one API, one host, one database to support both types of Blazor

# Examples To Show

* Creating Components that can be used multiple times (Standings.cs)
* Dependency Injection with services (Shared/Services/*.cs & Startup.cs & Program.cs)
* Sorting without JavaScript (Standings.cs)
* Routing / Routing with ID (Events.razor)
* Javascript interopt (Charts) **On Chart JS branch**
* Edit Form **In Progress**


# Resources
* [Blazor Train](https://blazortrain.com/)
* [Nick Chapsas - Blazor Fundamentals](https://www.youtube.com/playlist?list=PLUOequmGnXxPrY79JGnF72e1Pba8z93zo)
* [Microsoft Blazor: Building Web Applications in .NET 2nd Edition by Peter Himschoot](https://amzn.to/3eUYGJf)
