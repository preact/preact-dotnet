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

```csharp
public static class Neglect
{
  public static void LogEvent(UserInfo user, string eventName, string note)
  {
      try
      {
          LessNeglect.LessNeglectApi.Client.CreateActionEvent(new LessNeglect.ActionEventCreateRequest()
          {
              Event = new LessNeglect.ActionEvent()
              {
                  Name = eventName,
                  Note = note
              },
              Person = new LessNeglect.Person()
              {
                  Email = user.Email,
                  Name = user.FullName,
                  ExternalId = user.Username,
                  Properties = GetAccountPropertiesDictionary(user)
              }
          });

      }
      catch(Exception ex) {
#if DEBUG
          throw ex;
#endif
      }
  }

  public static void UpdatePerson(UserInfo user)
  {
      try
      {
          LessNeglect.LessNeglectApi.Client.UpdatePerson(new LessNeglect.PersonUpdateRequest()
          {
              Person = new LessNeglect.Person()
              {
                  Email = user.Email,
                  Name = user.FullName,
                  ExternalId = user.Username,
                  Properties = GetAccountPropertiesDictionary(user)
              }
          });

      }
      catch (Exception ex)
      {
#if DEBUG
          throw ex;
#endif
      }

  }

  public static Dictionary<string, object> GetAccountPropertiesDictionary(UserInfo user)
  {
      Dictionary<string, object> properties = new Dictionary<string, object>();

      properties["account_level"] = user.AccountLevel;
      properties["account_level_name"] = user.AccountLevelName;
      properties["custom_domain"] = user.CustomDomainName;
      properties["is_paying"] = user.IsPaying ? "1" : "0";
      properties["created_at"] = user.DateCreated;

      return properties;
  }
}
```

Copyright (c) 2011-2012 Christopher Gooley. See LICENSE.txt for further details.