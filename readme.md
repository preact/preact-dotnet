Preact C# Client
===
Allow your .NET app to easily submit server-side messages and events to Preact.

You can optionally install the Preact Client from [NuGet](http://nuget.org/packages/Preact/).


Usage
---

Add your project code and secret to your web.config:

```xml
  <appSettings>
    ...
    <add key="PreactProjectCode" value="asdfasdf"/>
    <add key="PreactProjectApiSecret" value="asdfasdf12341234"/>
    ...
  </appSettings>
```

Add a Reference to the Preact library in your Project (either directly to the source, or compile it first and include the .dll)

Then, log events as they happen using the client:

```csharp
  Preact.Api.Client.LogEvent(new Preact.ActionEventCreateRequest()
  {
      Event = new Preact.ActionEvent()
      {
          Name = "event-name"
      },
      Person = new Preact.Person()
      {
          Email = "gooley@preact.io",
          Name = "Christopher Gooley",
          ExternalId = "gooley"
      }
  });
```

Sample Helper Class
---

We suggest you create a simple helper class such as preact.cs to convert your User data model into a Preact Person and submit the event.

Here's a nice sample gist: https://gist.github.com/azcoov/5596023

And then, you can log stuff nice and easily:
```csharp
Preact.LogEvent(currentUserObject, "updated-profile")
```

Copyright (c) 2011-2013 Preact. See LICENSE.txt for further details.