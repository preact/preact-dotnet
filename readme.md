LessNeglect Ruby Client
===
Allow your .NET app to easily submit server-side messages and events to LessNeglect.

Usage
---

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

public static class Neglect
{
  public static void LogEvent(UserInfo user, string eventName, int? magnitude, string note, Dictionary<string, object> eventLinks)
  {
      try
      {
          LessNeglect.LessNeglectApi.Client.CreateActionEvent(new LessNeglect.ActionEventCreateRequest()
          {
              Event = new LessNeglect.ActionEvent()
              {
                  Name = eventName,
                  Magnitude = magnitude.GetValueOrDefault(0),
                  Note = note,
                  Links = GetActionLinks(eventLinks)
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

  public static LessNeglect.PersonActionLink[] GetActionLinks(Dictionary<string, object> items)
  {
      List<LessNeglect.PersonActionLink> links = new List<LessNeglect.PersonActionLink>();

      if (items != null && items.Count > 0)
      {
          foreach (var key in items.Keys)
          {
              if (items[key] != null)
              {
                  links.Add(new LessNeglect.PersonActionLink() { Name = key, Href = items[key].ToString() });
              }
          }
      }

      return links.ToArray();
  }

  private static string GetSetting(List<SitePreferenceSetting> settings, string setting)
  {
      foreach (var s in settings)
      {
          if (s.PreferenceType.Name.Equals(setting, StringComparison.InvariantCultureIgnoreCase))
          {
              return s.Value.ToString();
          }
      }
      return null;
  }
}
```

Copyright
===
Copyright (c) 2011-2012 Christopher Gooley. See LICENSE.txt for further details.