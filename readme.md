LessNeglect C# Client
===
Allow your .NET app to easily submit server-side messages and events to LessNeglect.

Usage
---

Add your project code and secret to your web.config:

```xml
  <appSettings>
    ...
    <add key="LessNeglectProjectCode" value="asdfasdf"/>
    <add key="LessNeglectProjectApiSecret" value="asdfasdf12341234"/>
    ...
  </appSettings>
```

Add a Reference to the LessNeglect library in your Project (either directly to the source, or compile it first and include the .dll)

Then, log events as they happen using the client:

```csharp
  LessNeglect.LessNeglectApi.Client.CreateActionEvent(new LessNeglect.ActionEventCreateRequest()
  {
      Event = new LessNeglect.ActionEvent()
      {
          Name = "event-name"
      },
      Person = new LessNeglect.Person()
      {
          Email = "gooley@foliohd.com",
          Name = "Christopher Gooley",
          ExternalId = "gooley"
      }
  });
```

Sample Helper Class
---

We suggest you create a simple helper class such as neglect.cs to convert your User data model into a LessNeglect Person and submit the event.

Here's a nice sample gist: https://gist.github.com/3738425

And then, you can log stuff nice and easily:
```csharp
Neglect.LogEvent(currentUserObject, "uploaded-image")
```

Copyright (c) 2011-2012 Christopher Gooley. See LICENSE.txt for further details.